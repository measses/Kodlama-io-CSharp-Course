using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.Business.Abstract;
using HW3.DataAccess.Abstract;
using HW3.Entitites;

namespace HW3.Business.Concrete
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
