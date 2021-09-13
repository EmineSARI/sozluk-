using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writeDal;

        public WriterManager(IWriterDal writeDal)
        {
            _writeDal = writeDal;
        }

        public Writer GetByID(int id)
        {
            return _writeDal.Get(x=>x.WriterID==id);
        }

        public List<Writer> GetList()
        {
            return _writeDal.List();
        }

        public void WriterAdd(Writer writer)
        {
            _writeDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writeDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writeDal.Update(writer);
        }
    }
}
