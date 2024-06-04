using PocApplication.Entities.Abstract;

namespace PocApplication.Entities
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Number { get; set; }
        public string? Email { get; set; }
        public string? GsmNumber { get; set; }
        public IList<ExamResult>? ExamResults { get; set; }
    }
}
