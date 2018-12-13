using System;
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

        public DataTable GetAllUser()
        {

            cnx.Open();

            MySqlCommand cmd = new MySqlCommand(); //Ou : MySqlCommand cmd = cnx.CreateCommand();

            // en gros les 2 prochaine ligne veulent dire : select * from user;
            cmd.CommandText = "user";
            cmd.CommandType = CommandType.TableDirect;
            cmd.Connection = cnx;

            MySqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            cnx.Close();
            return dt;
        }

        public User GetUserById(string user_id)
        {
            cnx.Open();
            string sql = "SELECT * from user where id='" + user_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            MySqlDataReader rdr = cmd.ExecuteReader();
            User user = null;
            while (rdr.Read())
            {
                user = new User(rdr[0].ToString(), rdr[1].ToString());
            }
            cnx.Close();
            //devrais retourner le pasword du user
            return user;
        }

        public String GetPasswordByUser(string user_id)
        {
            cnx.Open();
            string sql = "SELECT password from user where id='" + user_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            MySqlDataReader rdr = cmd.ExecuteReader();

            string pass = rdr.Read().ToString();
            cnx.Close();
            //devrais retourner le pasword du user
            return pass;
        }

        public Boolean CreateUser(User user)
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
