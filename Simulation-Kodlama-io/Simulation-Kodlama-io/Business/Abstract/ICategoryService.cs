using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW3.Entitites;

namespace HW3.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
