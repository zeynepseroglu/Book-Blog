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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void TAdd(Content t)
        {
            _contentDal.Insert(t);
        }

        public void TDelete(Content t)
        {
            _contentDal.Delete(t);
        }

        public Content TGetByID(int id)
        {
            return _contentDal.GetByID(id);
        }

        public List<Content> TGetList()
        {
            return _contentDal.GetList();
        }

        public List<Content> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Content t)
        {
            _contentDal.Update(t);
        }
    }
}
