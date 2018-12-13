using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["username"] = Request.Form["username"];
            Session["password"] = Request.Form["password"];
            Label4.Text = Request.Form["username"];
        }
    }
}