using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace RegistroArticulosDetalle.Entidades
{
    public class CotizarArticulosDetalle
    {
        [Key]

        public int Id { get; set; }
        public int CotizarId { get; set; }
        public int ArticuloId { get; set; }
        public int PersonaId { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulo { get; set; }

        [ForeignKey("PersonaId")]
        public  virtual Personas Persona { get; set; }
        

        public CotizarArticulosDetalle()
        {
            Id = 0;
            CotizarId = 0;
            
        }

        public CotizarArticulosDetalle(int id, int cotizarId, int articuloId, int personaId, int cantidadCotizada, int precio, int importe)
        {
            Id = id;
            CotizarId = cotizarId;
            ArticuloId = articuloId;
            PersonaId = personaId;
            Cantidad = cantidadCotizada;
            Precio = precio;
            Importe = importe;
        }
    }
}
