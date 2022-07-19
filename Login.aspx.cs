using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnocaDemo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
                Response.Redirect("Dashboard.aspx");
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
          string Pemail = TextBox1.Text.ToLower();
          string Ppassword = TextBox3.Text;

        SqlConnection con = new SqlConnection(@"Server=demo.aydmr.store\MSSQLSERVER2019;Initial Catalog=aydmrdemo;User=aydmradmin;password=Tg8pf99#4");
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select* from users WHERE useremail=@email";
        cmd.Parameters.AddWithValue("@email", Pemail);
        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            if (dr["userpassword"].ToString() == Ppassword)
            {
                Session.Add("User", dr["id"].ToString());
                Session.Add("Useremail", dr["useremail"].ToString());
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Literal1.Text = "<br/><br/><div class='alert alert-danger'>Kullanıcı giriş bilgileri yanlış!</div>";
            }
            
        }
        else
        {
            Literal1.Text = "<br/><br/><div class='alert alert-danger'>Kullanıcı bulunamadı!</div>";

        }


        dr.Close();
        con.Close();


        }
    }
}