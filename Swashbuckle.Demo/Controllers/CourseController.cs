using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Swashbuckle.Demo.Models;
using Swashbuckle.Swagger.Annotations;

namespace Swashbuckle.Demo.Controllers
{
    /// <summary>
    /// List of courses
    /// </summary>
    public class CourseController : ApiController
    {
        /// <summary>
        /// Returns the list of available courses.
        /// </summary>
        [SwaggerResponse(HttpStatusCode.OK, "List of courses")]
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
