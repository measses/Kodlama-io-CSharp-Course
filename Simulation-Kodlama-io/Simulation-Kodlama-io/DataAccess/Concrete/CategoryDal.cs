using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.DataAccess.Abstract;
using HW3.Entitites;

namespace HW3.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal{

        List<Category> _categories;

        public CategoryDal()
        {
            Category c1 = new Category();
            c1.CategoryName = "Java";
            c1.CategoryId = 1;

            Category c2 = new Category();
            c2.CategoryName = "C#";
            c2.CategoryId = 2;

            Category c3 = new Category();
            c3.CategoryName = "Python";
            c3.CategoryId = 3;


            _categories = new List<Category> { c1,c2,c3 };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category güncellendi.");
        }
    }
}
