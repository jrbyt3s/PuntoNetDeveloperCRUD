
using GestionDeCursos.Data.Models;

namespace GestionDeCursos.Data.Repositories
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        IRepository<Course> CourseRepository { get; }
        IRepository<Instructor> InstructorRepository { get; }

        Task Complete();
    }
}
