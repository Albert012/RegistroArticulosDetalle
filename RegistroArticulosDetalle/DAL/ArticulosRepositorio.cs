using RegistroArticulosDetalle.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RegistroArticulosDetalle.Entidades;


namespace RegistroArticulosDetalle.BLL
{
    public class ArticulosRepositorio : Repositorio<Articulos>
    {
        public ArticulosRepositorio(Contexto contexto) : base(contexto)
        {

        }

        public override bool Modificar(Articulos articulo)
        {
            bool paso = false;

            try
            {
                foreach (var item in articulo.Detalle)
                {
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    _contexto.Entry(item).State = estado;
                }

                _contexto.Entry(articulo).State = EntityState.Modified;
                if (_contexto.SaveChanges() > 0)
                    paso = true;

            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public override Articulos Buscar(int id)
        {
            Articulos articulo = new Articulos();
            try
            {
                articulo = _contexto.Articulos.Find(id);
                articulo.Detalle.Count();

                foreach (var item in articulo.Detalle)
                {
                    var s = item.Articulo.Descripcion;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return articulo;
        }


    }
}
