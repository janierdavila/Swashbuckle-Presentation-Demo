using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Swashbuckle.Demo.Models;

namespace Swashbuckle.Demo.Controllers
{
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

        public IHttpActionResult Get()
        {
            return Ok(_students);
        }

        public IHttpActionResult Get(int id)
        {
            var student = _students.FirstOrDefault(st => st.Id == id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        public IHttpActionResult Post([FromBody]Student value)
        {
            return Ok();
        }
    }
}
