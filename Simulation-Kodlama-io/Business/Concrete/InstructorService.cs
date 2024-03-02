using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.Business.Abstract;
using Simulation-Kodlama-io.DataAccess.Abstract;
using Simulation-Kodlama-io.Entitites;

namespace Simulation-Kodlama-io.Business.Concrete
{
    public class InstructorService : IInstructorService
    {   
        private readonly IInstructorDal _instructorDal;

        public InstructorService(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public List<Instructor> GetInstructors()
        {
           return _instructorDal.GetAll();
        }
    }
}
