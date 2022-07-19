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
    public partial class Güncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            güncellediv.Visible = false;
            for (int i = 1970; i < 2023; i++)
            {
                DropDownList1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filmAd = TextBox1.Text;

            using (aydmrdemoContext context = new aydmrdemoContext())
            {

                var film = context.Film.Where(p => p.filmAd.ToLower() == filmAd.ToLower()).FirstOrDefault();

                if (film == null)
                {
                    Literal1.Text = "<br/><br/><div class='alert alert-danger alert-dismissible fade show'>Film bulunamadı</div>";
                }
                else
                {
                    güncellediv.Visible = true;
                    TextBox2.Text = film.filmAd;
                    DropDownList1.SelectedItem.Text = film.filmYapimYil.ToString();
                    Literal1.Text = "";

                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                string filmAdeski = TextBox1.Text;
                string filmAd = TextBox2.Text;
                int filmYapimYil = Convert.ToInt32(DropDownList1.SelectedValue);


                var film = context.Film.Where(p => p.filmAd.ToLower() == filmAdeski.ToLower()).FirstOrDefault();
                film.filmAd = filmAd;
                film.filmYapimYil = filmYapimYil;
                context.SaveChanges();
                Literal1.Text = "<br/><br/><div class='alert alert-primary alert-dismissible fade show'>Güncellendi</div>";
            }
        }
    }
}