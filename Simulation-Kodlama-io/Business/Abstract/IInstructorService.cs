using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.Entitites;

namespace Simulation-Kodlama-io.Business.Abstract
{
    public interface IInstructorService
    {
        List<Instructor> GetInstructors();
    }
}
