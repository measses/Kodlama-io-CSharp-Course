using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.Entitites;
using Microsoft.VisualBasic.FileIO;

namespace Simulation-Kodlama-io.Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetCourseList();
        void Delete(Course course);
    }
}
