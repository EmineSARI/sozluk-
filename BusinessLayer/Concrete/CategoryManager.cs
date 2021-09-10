using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    //senin interface inde tanımlanan metotları kalıtsal yollarla al.
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }


        public List<Category> GetList()
        {

            //verileri listelemek için oluştu.
            return _categorydal.List();
            
        }

        public void CategoryAddBL(Category category)
        {
            _categorydal.Insert(category);


        }

        public void ICategoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryList()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }
    }
}
