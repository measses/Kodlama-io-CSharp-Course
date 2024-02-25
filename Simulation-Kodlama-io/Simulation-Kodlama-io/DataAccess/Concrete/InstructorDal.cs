using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.DataAccess.Abstract;
using HW3.Entitites;

namespace HW3.DataAccess.Concrete
{
    internal class InstructorDal : IInstructorDal
    {
        private List<Instructor> instructors = new List<Instructor>();
        public void Add(Instructor ins)
        {
            instructors.Add(ins);
        }

        public void Delete(Instructor ins)
        {
            instructors.Remove(ins);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor ins)
        {
            Console.WriteLine("İns güncellendi.");
        }
    }
}
