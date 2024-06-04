using PocApplication.Entities;

namespace PocApplication.Data.Abstract
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<IList<Student>> GetAllStudentsWithExamResultsAsync();
    }
}
