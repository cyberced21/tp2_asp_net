using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDao pdao = new UserDao("clone_kijiji", "root", "root");
            users.DataSource = pdao.GetAllUser();
            users.DataBind();

        }
    }
}