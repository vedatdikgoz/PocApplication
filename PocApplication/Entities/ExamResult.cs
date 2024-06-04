using PocApplication.Entities.Abstract;

namespace PocApplication.Entities
{
    public class ExamResult : IEntity
    {
        public int Id { get; set; }
        public Student? Student { get; set; }
        public int StudentId { get; set; }
        public Course? Course { get; set; }
        public int CourseId { get; set; }
        public int Score { get; set; }

    }
}
