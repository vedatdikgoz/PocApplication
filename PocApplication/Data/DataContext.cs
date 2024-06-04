using Microsoft.EntityFrameworkCore;
using PocApplication.Entities;


namespace PocApplication.Data
{
    public class DataContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; Database = PocAppDB; TrustServerCertificate=True");
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
    }
}
