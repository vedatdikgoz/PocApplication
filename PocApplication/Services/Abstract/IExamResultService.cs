using PocApplication.Entities;
using System;

namespace PocApplication.Services.Abstract
{
    public interface IExamResultService
    {
        Task<List<ExamResult>> GetAllAsync();
        Task<ExamResult> GetAsync(int id);
        Task AddAsync(ExamResult examResult);
        Task UpdateAsync(ExamResult examResult);
        Task DeleteAsync(ExamResult examResult);
    }
}
