
using GestionDeCursos.Data.Models;

namespace GestionDeCursos.Data.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<IEnumerable<Student>> GetStudentWithCourse();

        Task<Student?> GetStudentWithCourseById(int id);


    }
}
