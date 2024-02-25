using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.Entitites;
using Microsoft.VisualBasic.FileIO;

namespace HW3.Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetCourseList();
        void Delete(Course course);
    }
}
