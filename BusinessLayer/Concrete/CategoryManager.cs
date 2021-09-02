using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CategoryManager
    {
        GenericRepositorycs<Category> repo = new GenericRepositorycs<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if(p.CategotyName == "" || p.CategotyName.Length <= 3 || 
                p.CategotyDescription =="" || p.CategotyName.Length >= 51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
