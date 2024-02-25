using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HW3.Business.Abstract;
using HW3.DataAccess.Abstract;
using HW3.DataAccess.Concrete;
using HW3.Entitites;

namespace HW3.Business.Concrete
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
