using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Revela.Me.Controllers;
namespace Revela.Me.Controllers
{
    public class add
    {

        public void Registro(string name, string user, string age, string mail, string pass)  //registra usuarios en la bd
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO revela (nomb, user, age, mail, pass) VALUES(@nomb, @user, @age, @mail, @pass)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nomb", name);
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@age", age);
            comando.Parameters.AddWithValue("@mail", mail);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


       

        public void RegistroFeed(string user, int money, string card,string desc, byte[] ruta)  //registra usuarios en la bd
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO tofeed (user, mxn, card,descq, files) VALUES(@user, @mxn, @card, @descq,@files)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@mxn", money);
            comando.Parameters.AddWithValue("@card", card);
            comando.Parameters.AddWithValue("@descq", desc);
            comando.Parameters.AddWithValue("@files", ruta);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}