using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroArticulosDetalle.Entidades
{
    public class Personas
    {
        [Key]

        public int PersonaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Fecha = DateTime.Now;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
        }

        public override string ToString()
        {
            return Nombres;
        }

    }
}
