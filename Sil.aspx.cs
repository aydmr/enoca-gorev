using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnocaDemo.Entities;

namespace EnocaDemo
{
    public partial class Sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sildiv.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                var film = new Film { filmAd = filmAd.Text, filmYapimYil = Convert.ToInt32(filmYapimYil.Text),filmID = Convert.ToInt32(filmID.Text)};
                context.Film.Attach(film);
                context.Film.Remove(film);
                context.SaveChanges();
                Literal1.Text = "<br/><br/><div class='alert alert-warning'>Film kaydı silindi!</div>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            using (aydmrdemoContext context = new aydmrdemoContext())
            {

                var film = context.Film.Where(p => p.filmAd.ToLower() == TextBox1.Text.ToLower()).FirstOrDefault();

                if (film == null)
                {
                    Literal1.Text = "<br/><br/><div class='alert alert-danger alert-dismissible fade show'>Film bulunamadı</div>";
                }
                else
                {
                    sildiv.Visible = true;
                    filmAd.Text = film.filmAd;
                    filmYapimYil.Text = film.filmYapimYil.ToString();
                    filmID.Text= film.filmID.ToString();
                    Literal1.Text = "";

                }
            }
        }
    }
}