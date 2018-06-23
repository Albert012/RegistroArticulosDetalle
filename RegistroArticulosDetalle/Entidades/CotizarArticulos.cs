using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroArticulosDetalle.Entidades
{
    public class CotizarArticulos
    {
        public int CotizarId { get; set; }
        public DateTime Fecha { get; set; }

        [StringLength(100)]
        public string Comentarios { get; set; }
        public int Monto { get; set; }

        public virtual ICollection<CotizarArticulosDetalle> Detalle { get; set; }


        public CotizarArticulos()
        {
            this.Detalle = new List<CotizarArticulosDetalle>();
        }

        public void AgregarDetalle(int Id, int CotizarId, int ArticuloId, int PersonaId, int CantidadCotizada, int Precio, int Importe)
        {
          this.Detalle.Add(new CotizarArticulosDetalle(Id, CotizarId, ArticuloId, PersonaId, CantidadCotizada, Precio, Importe));
        }
    }
}
