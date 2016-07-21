using System.Collections.Generic;
using System.Web.Http;
using Swashbuckle.Demo.Models;

namespace Swashbuckle.Demo.Controllers
{
    public class CourseController : ApiController
    {
        public IHttpActionResult Get()
        {
            var courses = new List<Course>
            {
                new Course {Name = "Biology", Capacity = 34},
                new Course {Name = "English", Capacity = 50}
            };

            return Ok(courses);
        }
    }
}
