using PocApplication.Data.Abstract;
using PocApplication.Entities;

namespace PocApplication.Data.Concrete
{
    public class ExamResultRepository : GenericRepository<ExamResult, DataContext>, IExamResultRepository
    {
    }
}
