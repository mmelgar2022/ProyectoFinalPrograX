using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class tbl_destinoModel
    {
        public int id_destino { get; set; }
        public string descripcion { get; set; }
        public string coordenadas { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string horarios { get; set; }
    }
}
