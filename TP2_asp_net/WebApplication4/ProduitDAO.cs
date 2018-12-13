using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    class ProduitDAO
    {

        private MySqlConnection cnx = new MySqlConnection();

        public ProduitDAO(string db_name, string username, string password)
        {
            //sous-entend que c une base de donner phpmyadmin avec uwamp qui roule sur localhost
            cnx.ConnectionString = "Server=127.0.0.1;Uid=" + username + ";Pwd=" + password + ";Database=" + db_name + ";";

        }

        public DataTable GetAllProduit()
        {

            cnx.Open();

            MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();

            // en gros les 2 prochaine ligne veulent dire : select * from user;
            cmd.CommandText = "produit";
            cmd.CommandType = CommandType.TableDirect;
            cmd.Connection = cnx;

            MySqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            cnx.Close();
            return dt;
        }

        public Boolean CreateProduit(Produit produit)
        {
            cnx.Open();
            string sql = "INSERT INTO produit (id,name,category,price) VALUES" +
                " ('" + produit.id + "','" + produit.name + "', '" + produit.category + "', '"+ produit.price + "')";

            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            int row_affected = cmd.ExecuteNonQuery();

            cnx.Close();

            if (row_affected == 1) { return true; }
            else { return false; }
            

        }
    }
}