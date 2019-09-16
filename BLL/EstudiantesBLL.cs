using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro.Entidades;
using Registro.DAL;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Registro.BLL
{ 
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            Inscripciones inscripcion = new Inscripciones();
            bool paso = false;
            Contexto db = new Contexto();

            Console.WriteLine(estudiante.Balance);
            try
            {
                if (db.Estudiante.Add(estudiante) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(estudiante).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool GuardarBalance(int id, decimal balance)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();

            estudiante = db.Estudiante.Find(id);
            if(estudiante != null)
            {
                try
                {
                    estudiante.Balance += balance;

                    db.Entry(estudiante).State = EntityState.Modified;
                    paso = (db.SaveChanges() > 0);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    db.Dispose();

                }
            }

            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Estudiante.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Estudiantes Buscar(int id)
        {
            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();

            try
            {
                estudiante = db.Estudiante.Find(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return estudiante;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> estudiante)
        {
            List<Estudiantes> Lista = new List<Estudiantes>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Estudiante.Where(estudiante).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Lista;
        }


    }
}
