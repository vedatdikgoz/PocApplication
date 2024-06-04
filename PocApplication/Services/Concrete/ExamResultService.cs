using PocApplication.Data.Abstract;
using PocApplication.Entities;
using PocApplication.Services.Abstract;

namespace PocApplication.Services.Concrete
{
    public class ExamResultService : IExamResultService
    {
        private readonly IExamResultRepository _examResultRepository;
        public ExamResultService(IExamResultRepository examResultRepository)
        {
            _examResultRepository = examResultRepository;
        }
        public async Task AddAsync(ExamResult examResult)
        {
            await _examResultRepository.AddAsync(examResult);
        }

        public async Task DeleteAsync(ExamResult examResult)
        {
            await _examResultRepository.DeleteAsync(examResult);
        }

        public async Task<List<ExamResult>> GetAllAsync()
        {
            return await _examResultRepository.GetAllAsync();
        }

        public async Task<ExamResult> GetAsync(int id)
        {
            return await _examResultRepository.GetAsync(g => g.Id == id);
        }

        public async Task UpdateAsync(ExamResult examResult)
        {
            await _examResultRepository.UpdateAsync(examResult);
        }
    }
}
