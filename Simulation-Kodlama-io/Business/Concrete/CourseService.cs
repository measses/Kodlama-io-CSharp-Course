using Simulation-Kodlama-io.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.Business.Abstract;

namespace Simulation-Kodlama-io.Business.Concrete
{
    public class CourseService : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseService(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public List<Course> GetCourseList()
        {
            return _courseDal.GetAllCourses();
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);

        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }



        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
    }
}
