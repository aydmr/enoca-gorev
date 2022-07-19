using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EnocaDemo.Entities;

namespace EnocaDemo
{
    public partial class Ara : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Sayfa yüklenirken tarih ve Salon bilgilerini seçmemizi sağlayan Açılır kutuların içine verileri ekliyoruz.

                for (int i = 1970; i < 2023; i++)
                {
                    DropDownList1.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
                for (int i = 2023; i > 1970; i--)
                {
                    DropDownList2.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                using (aydmrdemoContext context = new aydmrdemoContext())
                {
                    DropDownList3.DataSource = context.Salon.ToList();
                    DropDownList3.DataTextField = "salonAd";
                    DropDownList3.DataValueField = "salonID";
                    DropDownList3.DataBind();

                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                int altyil = Convert.ToInt32(DropDownList1.SelectedValue);
                int üstyil = Convert.ToInt32(DropDownList2.SelectedValue);

                if ((context.Film.Where(P => P.filmYapimYil >= altyil && P.filmYapimYil <= üstyil).ToList()).Count == 0)
                {
                    Literal1.Text = "<br/><br/><div class='alert alert-danger'>Eşleşen sonuç bulunamadı!</div>";
                    GridView1.DataSource = "";
                    GridView1.DataBind();
                }
                else
                {
                    var result = from Film in context.Film
                                 where Film.filmYapimYil >= altyil && Film.filmYapimYil <= üstyil
                                 select new
                                 {
                                     FilmAdı = Film.filmAd,
                                     FilmYapımYılı = Film.filmYapimYil
                                 };
                    GridView1.DataSource = result.ToList();
                    GridView1.DataBind();
                    Literal1.Text = "";
                }

            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {


            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                if ((context.Film.Where(P => P.filmAd.ToLower().Contains(TextBox1.Text.ToLower())).ToList()).Count != 0)
                {
                    string key = TextBox1.Text;
                    var result = from Film in context.Film
                                 join Gosterim in context.Gosterim on Film.filmID equals Gosterim.filmID
                                 join Salon in context.Salon on Gosterim.salonID equals Salon.salonID
                                 where Film.filmAd.ToLower() == key.ToLower()
                                 select new
                                 {
                                     FilmAdı = Film.filmAd,
                                     FilmYapımYılı = Film.filmYapimYil,
                                     GösterimSalonu = Salon.salonAd,
                                     GösterimYılı = Gosterim.gosterimYil
                                 };
                    GridView1.DataSource = result.ToList();
                    GridView1.DataBind();
                    Literal1.Text = "";
                }
                else
                {
                    Literal1.Text = "<br/><br/><div class='alert alert-danger'>Eşleşen sonuç bulunamadı!</div>";
                    GridView1.DataSource = "";
                    GridView1.DataBind();
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                int salonıd = Convert.ToInt32(DropDownList3.SelectedValue);

                if ((context.Gosterim.Where(P => P.salonID == salonıd).ToList()).Count != 0)
                {

                    var result = from Gosterim in context.Gosterim
                                 join Film in context.Film on Gosterim.filmID equals Film.filmID
                                 join Salon in context.Salon on Gosterim.salonID equals Salon.salonID
                                 where Gosterim.salonID == salonıd
                                 select new
                                 {
                                     FilmAdı = Film.filmAd,
                                     FilmYapımYılı = Film.filmYapimYil,
                                     GösterimSalonu = Salon.salonAd,
                                     GösterimYılı = Gosterim.gosterimYil
                                 };
                    GridView1.DataSource = result.ToList();
                    GridView1.DataBind();
                    Literal1.Text = "";
                }
                else
                {
                    Literal1.Text = "<br/><br/><div class='alert alert-danger'>Eşleşen sonuç bulunamadı!</div>";
                    GridView1.DataSource = "";
                    GridView1.DataBind();
                }
            }
        }
    }
}