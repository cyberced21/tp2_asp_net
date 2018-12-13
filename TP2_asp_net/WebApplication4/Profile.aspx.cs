using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            User user = (User)Session["user"];
            Lbl_user.Text = user.id;
        }
        protected void btn_create_product_Click(object sender, EventArgs e)
        {  
            ProduitDAO pdao = new ProduitDAO("clone_kijiji", "root","root");
            
            pdao.CreateProduit(new Produit(product_id.Text,product_name.Text,product_category.Text,Convert.ToInt32(product_price.Text)));
        }
    }
}