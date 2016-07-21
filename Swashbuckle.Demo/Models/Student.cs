using System.Collections.Generic;

namespace Swashbuckle.Demo.Models
{
    /// <summary>
    /// Represents a student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The student's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The student's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The Student's age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The courses the student is enrolled in
        /// </summary>
        public IEnumerable<Course> Courses { get; set; } 
    }
}