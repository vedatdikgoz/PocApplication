using PocApplication.Data.Abstract;
using PocApplication.Entities;
using PocApplication.Services.Abstract;
using System;

namespace PocApplication.Services.Concrete
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task AddAsync(Course course)
        {
            await _courseRepository.AddAsync(course);
        }

        public async Task DeleteAsync(Course course)
        {
            await _courseRepository.DeleteAsync(course);
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await _courseRepository.GetAllAsync();
        }

        public async Task<Course> GetAsync(int id)
        {
            return await _courseRepository.GetAsync(g => g.Id == id);
        }

        public async Task UpdateAsync(Course course)
        {
            await _courseRepository.UpdateAsync(course);
        }
    }
}
