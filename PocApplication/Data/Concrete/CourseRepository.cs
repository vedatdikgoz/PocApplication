using Microsoft.EntityFrameworkCore;
using PocApplication.Data.Abstract;
using PocApplication.Entities;

namespace PocApplication.Data.Concrete
{
    public class CourseRepository : GenericRepository<Course, DataContext>, ICourseRepository
    {
      
    }
}
