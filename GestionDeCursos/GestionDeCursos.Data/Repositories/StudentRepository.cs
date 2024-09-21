using GestionDeCursos.Data.Database;
using GestionDeCursos.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCursos.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository( ApplicationDbContext context) : base(context){ 
        }
        public async Task<IEnumerable<Student>> GetStudentWithCourse()
        {
            
            return await Context.Students
                .Include(x => x.Course)
                .Include(x => x.InstructorId)
                .ToListAsync();
        }

        public async Task<Student?> GetStudentWithCourseById(int id)
        {
            return await Context.Students
                .Include(x => x.Course)
                .Include(x => x.InstructorId)
                .FirstOrDefaultAsync(x => x.Id == id);
                
        }
    }
}
