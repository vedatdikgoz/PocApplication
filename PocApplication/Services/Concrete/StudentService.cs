using PocApplication.Data.Abstract;
using PocApplication.Entities;
using PocApplication.Services.Abstract;

namespace PocApplication.Services.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task AddAsync(Student student)
        {
            await _studentRepository.AddAsync(student);
        }

        public async Task DeleteAsync(Student student)
        {
            await _studentRepository.DeleteAsync(student);
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task<Student> GetAsync(int id)
        {
            return await _studentRepository.GetAsync(g => g.Id == id);
        }

        public async Task UpdateAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
        }

        public async Task<List<Student>> GetAllStudentsWithExamResultsAsync()
        {
            return (List<Student>)await _studentRepository.GetAllStudentsWithExamResultsAsync();
        }


    }
}
