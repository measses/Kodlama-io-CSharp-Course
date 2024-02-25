using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.DataAccess.Abstract;
using Simulation-Kodlama-io.Entitites;

namespace Simulation-Kodlama-io.DataAccess.Concrete
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
