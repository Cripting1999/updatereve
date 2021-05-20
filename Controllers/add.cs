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
    }
}