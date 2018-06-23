using RegistroArticulosDetalle.DAL;
using RegistroArticulosDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Data.Entity;

namespace RegistroArticulosDetalle.BLL
{
    public class PersonasBLL
    {
        public static bool Guardar(Personas persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Personas.Add(persona) != null)
                {
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

        public static bool Modificar(Personas persona)
        {
            bool paso = true;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(persona).State = EntityState.Modified;
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
                Personas persona = contexto.Personas.Find(id);
                contexto.Personas.Remove(persona);

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

        public static Personas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Personas persona = new Personas();

            try
            {
                persona = contexto.Personas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return persona;
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> expression)
        {
            List<Personas> persona = new List<Personas>();
            Contexto contexto = new Contexto();

            try
            {
                persona = contexto.Personas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return persona;
        }


    }
}
