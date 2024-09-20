
using GestionDeCursos.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCursos.Data.Database
{
    public class ApplicationDbContext: DbContext
    {
        //Aqui hacemos el link entre el modelo y la tabla de la base de datos
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
