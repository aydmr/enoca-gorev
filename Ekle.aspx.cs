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
    public partial class Ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1970; i < 2023; i++)
            {
                DropDownList1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string filmAd = TextBox1.Text;
            int filmYapimYil = Convert.ToInt32(DropDownList1.SelectedValue);

            using (aydmrdemoContext context = new aydmrdemoContext())
            {
                var durum = (from Film in context.Film
                             where Film.filmAd == filmAd && Film.filmYapimYil == filmYapimYil
                             select Film).Count() > 0;

                

            if (durum != false)
            {
                Literal1.Text = "<br/><br/><div class='alert alert-info'>Film halihazırda kayıtlı!</div>";
            }
            else
            {
                context.Film.Add(new Film {filmAd = filmAd,filmYapimYil = filmYapimYil});
                context.SaveChanges();
                Literal1.Text = "<br/><br/><div class='alert alert-success'>Kayıt Edildi</div>";
            }
            }
        }
    }
}