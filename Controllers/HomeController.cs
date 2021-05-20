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

            if (TempData["x1"] != null)
            {
                ViewBag.Msg2 = TempData["x1"].ToString();
            }
            
            if (TempData["x2"] != null)
            {
                ViewBag.Msg3 = TempData["x2"].ToString();
            }

            if (TempData["x3"] != null)
            {
                ViewBag.Msg4 = TempData["x3"].ToString();
            }

            if (TempData["x4"] != null)
            {
                ViewBag.Msg5 = TempData["x4"].ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult Dash(string user, string mxn, string card)
        {
            //int money = int.Parse(mxn);
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
                string mai= leer["mail"].ToString();
                TempData["x1"] = name;
                TempData["x2"] = user;
                TempData["x3"] = aged;
                TempData["x4"] = mai;
                return RedirectToAction("Dash");
            }
            else
            {
                ViewBag.Msg = "¡Oh no, el usuario no ha sido encontrado!";
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
        public ActionResult Sign(string name, string user, string age, string mail, string pass)
        {
           add cc = new add();
           cc.Registro(name,user,age,mail,pass);
            ViewBag.Msg1 = "¡Hola, registrado con éxito!";  
            return View();
        }



















        public ActionResult News()
        {
            return View();
        }
    }
}