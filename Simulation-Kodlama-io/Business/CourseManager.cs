using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.Entitites;

namespace Simulation-Kodlama-io.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAllCourses();
        }

    }
}
