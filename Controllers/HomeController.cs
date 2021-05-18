using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using Revela.Me.Controllers;


namespace Revela.Me.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }











        [HttpGet]
        public ActionResult Dash()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dash(string user, string mxn, string pass)
        {
            return View();
        }















        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM revela WHERE user='" + user + "'AND pass='" + pass + "' ", conexion);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string name = leer["nomb"].ToString();
                string userb = leer["user"].ToString();
                string aged = leer["age"].ToString();
                return RedirectToAction("Dash");
            }
            conexion.Close();
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }











        [HttpGet]
        public ActionResult Sign()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sign(string name, string user, string age, string card, string pass)
        {
           add cc = new add();
           cc.Registro(name,user,age,card,pass);
           return View("Login");
        }



















        public ActionResult News()
        {
            return View();
        }
    }
}