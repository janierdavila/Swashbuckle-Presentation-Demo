using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Swashbuckle.Demo.Models;
using Swashbuckle.Swagger.Annotations;

namespace Swashbuckle.Demo.Controllers
{
    /// <summary>
    /// Everything about Student
    /// </summary>
    public class StudentController : ApiController
    {
        private readonly List<Student> _students;

        public StudentController()
        {
            this._students = new List<Student>
            {
                new Student { Id = 1, Age = 23, FirstName = "Janier", LastName = "Davila", Courses = new List<Course>
                {
                    new Course { Capacity = 50, Name = "English"},
                    new Course { Capacity = 34, Name = "Biology"}
                }},
                new Student { Id = 2, Age = 53, FirstName = "Cuban", LastName = "Student", Courses = new List<Course>
                {
                    new Course { Capacity = 50, Name = "English"}
                }}
            };
        }

        /// <summary>
        /// Returns the list of students registered.
        /// </summary>
        [SwaggerResponse(HttpStatusCode.OK, "List of registered students")]
        public IHttpActionResult Get()
        {
            return Ok(_students);
        }

        /// <summary>
        /// Returns the request student, if found.
        /// </summary>
        /// <param name="id">The ID</param>
        [SwaggerResponse(HttpStatusCode.OK, "The found student obj")]
        [SwaggerResponse(HttpStatusCode.NotFound, "No student found for the provided ID")]
        public IHttpActionResult Get(int id)
        {
            var student = _students.FirstOrDefault(st => st.Id == id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        /// <summary>
        /// It does nothing!!!
        /// </summary>
        /// <param name="value">The Student to create</param>
        [SwaggerResponse(HttpStatusCode.OK, "All is good")]
        public IHttpActionResult Post([FromBody]Student value)
        {
            return Ok();
        }
    }
}
