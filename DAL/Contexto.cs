using Registro.Entidades;
using System.Data.Entity;


namespace Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiante { get; set; }

        public DbSet<Inscripciones> Inscripcion { get; set; }

        public Contexto() : base("ConStr")
        { }


    }
}
