using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_click(object sender, EventArgs e)
        {
            UserDao udao = new UserDao("clone_kijiji", "root", "root");
            User user = new User(username.Text, password.Text);
            udao.CreateUser(user);
            Response.Redirect("~/Login");
        }
    }
}