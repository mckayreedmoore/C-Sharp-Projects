using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCSharpChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var aStudent = new Student() { firstName = "Jim", lastName = "Bo", isFulltimeStudent = true };

                ctx.Students.Add(aStudent);
                ctx.SaveChanges();

            }
        }
    }

    public  class SchoolContext: DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isFulltimeStudent { get; set; }
        
    }
}
