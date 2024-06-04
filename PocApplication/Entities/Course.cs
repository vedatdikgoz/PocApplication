using PocApplication.Entities.Abstract;

namespace PocApplication.Entities
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IList<ExamResult>? ExamResults { get; set; }
    }
}
