﻿using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Produits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProduitDAO pdao = new ProduitDAO("clone_kijiji", "root", "root");
            product.DataSource = pdao.GetAllProduit();
            product.DataBind();
        }
    }
}