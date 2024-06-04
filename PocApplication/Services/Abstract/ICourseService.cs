using PocApplication.Entities;
using System;

namespace PocApplication.Services.Abstract
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllAsync();
        Task<Course> GetAsync(int id);
        Task AddAsync(Course course);
        Task UpdateAsync(Course course);
        Task DeleteAsync(Course course);

    }
}
