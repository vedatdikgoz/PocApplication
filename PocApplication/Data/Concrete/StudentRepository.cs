using Microsoft.EntityFrameworkCore;
using PocApplication.Data.Abstract;
using PocApplication.Entities;

namespace PocApplication.Data.Concrete
{
    public class StudentRepository : GenericRepository<Student, DataContext>, IStudentRepository
    {
        public async Task<IList<Student>> GetAllStudentsWithExamResultsAsync()
        {
            using var context = new DataContext();
            var students = await context.Students
                          .Include(s => s.ExamResults)
                          .ThenInclude(er => er.Course)
                          .ToListAsync();
            return students;
        }

    }
}
