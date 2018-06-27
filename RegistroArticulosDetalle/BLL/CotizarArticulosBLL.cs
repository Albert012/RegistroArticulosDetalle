using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;
using RegistroArticulosDetalle.Entidades;
using RegistroArticulosDetalle.DAL;

namespace RegistroArticulosDetalle.BLL
{
    public class CotizarArticulosBLL
    {
        public static bool Guardar(CotizarArticulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Cotizar.Add(articulo) != null)
                {
                    foreach (var item in articulo.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticuloId).CantCotizada += item.Cantidad;
                    }

                    contexto.SaveChanges();
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;

        }

        public static bool Modificar(CotizarArticulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var cotizacionAnt = BLL.CotizarArticulosBLL.Buscar(articulo.CotizarId);

                foreach (var item in cotizacionAnt.Detalle)
                {
                    contexto.Articulos.Find(item.ArticuloId).CantCotizada -= item.Cantidad;

                    if(!articulo.Detalle.ToList().Exists(a => a.Id == item.Id))
                    {
                        contexto.Articulos.Find(item.ArticuloId).CantCotizada -= item.Cantidad;
                        item.Articulo = null;
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in articulo.Detalle)
                {
                    contexto.Articulos.Find(item.ArticuloId).CantCotizada += item.Cantidad;

                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;

                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return paso;
        }
        
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                CotizarArticulos articulo = contexto.Cotizar.Find(id);

                foreach (var item in articulo.Detalle)
                {
                    var cotizar = contexto.Articulos.Find(item.ArticuloId).CantCotizada -= item.Cantidad;
                }

                contexto.Cotizar.Remove(articulo);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        public static CotizarArticulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            CotizarArticulos articulo = new CotizarArticulos();

            try
            {
                articulo = contexto.Cotizar.Find(id);
                articulo.Detalle.Count();

                foreach (var item in articulo.Detalle)
                {
                    string d = item.Articulo.Descripcion;
                    string n = item.Persona.Nombres;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return articulo;
        }

        public static List<CotizarArticulos> GetList(Expression<Func<CotizarArticulos, bool>> expression)
        {
            List<CotizarArticulos> articulos = new List<CotizarArticulos>();
            Contexto contexto = new Contexto();

            try
            {
                articulos = contexto.Cotizar.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return articulos;
        }
       
        public static Decimal CalcularImporte(Decimal cantidad, Decimal precio)
        {
            return cantidad * precio;
        }

        public static Decimal CalcularTotal(Decimal importe)
        {            
            return importe;
        }

    }
}
