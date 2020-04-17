using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SapphiroMVC.Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public int id_rol { get; set; }
        public string nombre_usuario { get; set; }
        public string contraseña { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string nombre_empresa { get; set; }
    }
}