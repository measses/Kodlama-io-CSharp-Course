using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.Entitites;

namespace Simulation-Kodlama-io.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
         List<Course> _allCourses;

        public CourseDal()
        {
           Course c1 = new Course();
           c1.CourseId = 1;
           c1.CourseName = "Kurs1";
           c1.CourseInstructor = "KCO";
           c1.CourseCategory = " Yazılım";
           c1.CoursePercentage = 31;

           Course c2=new Course();
           c2.CourseId = 2;
           c2.CourseName = "Kurs2";
           c2.CourseInstructor = "KCO";
           c2.CourseCategory = " Yazılım";
           c2.CoursePercentage = 32;

           Course c3 = new Course();
           c3.CourseId = 3;
           c3.CourseName = "Kurs3";
           c3.CourseInstructor = "new Instructor()";
           c3.CourseCategory = " Yazılım";
           c3.CoursePercentage = 33;

           _allCourses =new List<Course>{c1,c2,c3}
           ;

        }
        public void Add(Course course)
        {
            _allCourses.Add(course);
        }

        public void Delete(Course course)
        {
            _allCourses.Remove(course);
        }

        public List<Course> GetAllCourses()
        {
            return _allCourses;
        }

        public void Update(Course course)
        {
            var existedCourse = _allCourses.FirstOrDefault(course1 => course1.CourseId == course.CourseId);
            if (existedCourse != null)
            {
                existedCourse.CourseId = course.CourseId;
                existedCourse.CourseName = course.CourseName;
            }
            else
            {
                Console.WriteLine("Veritabanındaki course güncellenmedi");
            }
            
        }
    }
}
