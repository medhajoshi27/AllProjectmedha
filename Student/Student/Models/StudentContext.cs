using System.Data.Entity;

namespace Student.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<StudentOne> StudentOnes { get; set; }
    }
}