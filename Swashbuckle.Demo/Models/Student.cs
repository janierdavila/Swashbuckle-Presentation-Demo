using System.Collections.Generic;

namespace Swashbuckle.Demo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public IEnumerable<Course> Courses { get; set; } 
    }
}