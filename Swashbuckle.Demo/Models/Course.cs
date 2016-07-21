namespace Swashbuckle.Demo.Models
{
    /// <summary>
    /// Represents a course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Name of the course
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Max number of students
        /// </summary>
        public int Capacity { get; set; }
    }
}