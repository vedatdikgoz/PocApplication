using PocApplication.Entities;
using System;

namespace PocApplication.Services.Abstract
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllAsync();
        Task<List<Student>> GetAllStudentsWithExamResultsAsync();
        Task<Student> GetAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(Student student);
    }
}
