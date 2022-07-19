using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnocaDemo.Entities;

namespace EnocaDemo
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GrafikSalon();
            TabloFilm();

        }

        private void GrafikSalon()
        {
            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                var result = from Salon in context.Salon
                             select new
                             {
                                 GösterimSalonu = Salon.salonAd
                             };
                var liste = result.ToList();

                this.myBarChart.Titles.Clear();
                this.myBarChart.Series.Clear();
                this.myBarChart.Series.Add("Salonda Gösterime Giren Film");
                this.myBarChart.Series[0].Color = Color.Red;


                foreach (var GösterimSalonu in liste)
                {
                    var durum = (from Salon in context.Salon
                                 join Gosterim in context.Gosterim on Salon.salonID equals Gosterim.salonID
                                 join Film in context.Film on Gosterim.filmID equals Film.filmID
                                 where Salon.salonAd == GösterimSalonu.GösterimSalonu
                                 select Film).Count();

                    this.myBarChart.Series[0].Points.AddXY(GösterimSalonu.GösterimSalonu, durum);
                }
            }
        }

        void TabloFilm()
        {
            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                var filmler = from Film in context.Film
                              join Gosterim in context.Gosterim on Film.filmID equals Gosterim.filmID
                              join Salon in context.Salon on Gosterim.salonID equals Salon.salonID
                              select new
                              {
                                  FilmAdı = Film.filmAd,
                                  FilmYapımYılı = Film.filmYapimYil,
                                  GösterimSalonu = Salon.salonAd,
                                  GösterimYılı = Gosterim.gosterimYil
                              };

                var filmliste = filmler.ToList();
                
                foreach (var film in filmliste)
                {
                    Literal1.Text += "<tr><td>"+film.FilmAdı+"</td><td>"+film.FilmYapımYılı+"</td><td>"+film.GösterimSalonu+"</td><td>"+film.GösterimYılı+"</td></tr>";
                }

            }



        }


    }
}