using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;
using SapphiroMVC.Models;


namespace SapphiroMVC.Controllers
{
    public class UsuarioController : Controller
    {

        NpgsqlConnection conexion = new NpgsqlConnection();
        NpgsqlCommand comando = new NpgsqlCommand();
        NpgsqlDataReader dr;
        // GET: Usuario

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            conexion.ConnectionString = "UserID = postgres; Password = 0609; host = localhost; Port=5432; Database=bdsapphiro;";
        }

        [HttpPost]
        public ActionResult Verify(Usuario usu)
        {
            connectionString();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = "SELECT * FROM \"bdsapphiro\".\"Usuario\" WHERE nombre_usuario='" + usu.nombre_usuario + "'AND contraseña='" + usu.contraseña + "'";
            dr = comando.ExecuteReader();

            if (dr.Read())
            {
                conexion.Close();
                return View("CuentaCreada");
            }
            else
            {
                conexion.Close();
                return View("Error");
            }
        }

    }
}