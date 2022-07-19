using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnocaDemo
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
            else
            {
                UsersLooder();
            }
        }

        void UsersLooder()
        {
            Literal1.Text = (string) Session["Useremail"];
        }
    }
}