using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Simulation-Kodlama-io.Business.Abstract;
using Simulation-Kodlama-io.DataAccess.Abstract;
using Simulation-Kodlama-io.DataAccess.Concrete;
using Simulation-Kodlama-io.Entitites;

namespace Simulation-Kodlama-io.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDal _category;

        public CategoryService(ICategoryDal category)
        {
            _category = category;
        }

        public List<Category> GetCategories()
        {  
            return _category.GetAll();
        }

        public void Delete(Category category)
        {
            _category.Delete(category);

        }

        public void Update(Category category)
        {
            _category.Update(category);
        }



        public void Add(Category category)
        {
            _category.Add(category);
        }
    }
}
