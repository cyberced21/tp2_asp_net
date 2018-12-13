using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["username"] != null)
            {
                UserDao udao = new UserDao("clone_kijiji", "root", "root");
                User user = udao.GetUserById(Request.Form["username"]);
                if (user.id == Request.Form["password"].ToString())
                {
                    Session["user"] = user;
                    Response.Redirect("~/Profile");
                }
                else
                {
                    Response.Redirect("~/Login");
                }
            }
        }
    }
}