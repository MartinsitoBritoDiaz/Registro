using System.Data.Entity;
using Registro.Entidades;


namespace Registro.DAL
{
    public class Contexto : DbContext{
        public DbSet<Estudiantes> Estudiante { get; set; }

        public Contexto() : base("ConStr")
        {       }
    }
}
