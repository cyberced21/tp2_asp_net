﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class UserDao
    {

        private MySqlConnection cnx = new MySqlConnection();

        public UserDao(string db_name, string username, string password)
        {
            //sous-entend que c une base de donner phpmyadmin avec uwanp qui roule sur localhost
            cnx.ConnectionString = "Server=127.0.0.1;Uid=" + username + ";Pwd=" + password + ";Database=" + db_name + ";";

        }

        public List<User> GetAllProduit()
        {

            cnx.Open();

            MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();

            // en gros les 2 prochaine ligne veulent dire : select * from user;
            cmd.CommandText = "user";
            cmd.CommandType = CommandType.TableDirect;
            cmd.Connection = cnx;

            MySqlDataReader dr = cmd.ExecuteReader();

            List<User> list_user = new List<User>();

            while (dr.Read())
            {
                //parcoure la table et cre une liste d'objet produit
                list_user.Add(new User(dr[0].ToString(), dr[1].ToString()));
            }

            cnx.Close();
            //pour l'instant retourner un data reader su lequel on peut iterer je trouve ca pas si pire
            return list_user;
        }

        public String GetPasswordByUser(string user_id)
        {

            string sql = "SELECT PASSWORD from user where id='" + user_id + "';";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            MySqlDataReader rdr = cmd.ExecuteReader();


            cnx.Close();
            //devrais retourner le pasword du user
            return rdr.Read().ToString();
        }

        public Boolean CreateProduit(User user)
        {
            cnx.Open();
            string sql = "INSERT INTO user (id,password) VALUES" +
                " ('" + user.id + "','" + user.password + "')";

            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            int row_affected = cmd.ExecuteNonQuery();

            cnx.Close();

            if (row_affected == 1) { return true; }
            else { return false; }
        }
    }
}
