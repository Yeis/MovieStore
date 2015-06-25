using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class ClienteModel
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string  Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }


    }
}