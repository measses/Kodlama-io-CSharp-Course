using Simulation-Kodlama-io.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation-Kodlama-io.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor ins);
        void Update(Instructor ins);
        void Delete(Instructor ins);
    }
}
