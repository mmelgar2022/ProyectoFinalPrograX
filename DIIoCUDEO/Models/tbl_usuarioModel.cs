using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class tbl_usuarioModel
    {
        public int id_usaurio { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string nacionalidad { get; set; }
        public string coordenadas { get; set; }
        public string estadia { get; set; }
        public string hospedaje { get; set; }
        public int id_transporte { get; set; }
        public int id_destino { get; set; }
    }
}
