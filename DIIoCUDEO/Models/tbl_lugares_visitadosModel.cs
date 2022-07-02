using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class tbl_lugares_visitadosModel
    {
        public int id_visitas { get; set; }
        public string lugar { get; set; }
        public string coordenadas { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string horarios { get; set; }
        public string estado { get; set; }
    }
}
