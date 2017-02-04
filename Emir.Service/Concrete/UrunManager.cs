using Emir.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emir.Entities.Concrete;
using Emir.Dal.Abstract;

namespace Emir.Service.Concrete
{
    public class UrunManager : IUrunService
    {
        private IUrunDal _uruntDal;
        public UrunManager(IUrunDal uruntDal)
        {
            _uruntDal = uruntDal;
        }

        public void Add(Urun urun)
        {
            _uruntDal.Add(urun);
        }

        public void Delete(int urunId)
        {
            _uruntDal.Delete(new Urun { UrunId = urunId });
        }

        public List<Urun> GetAll()
        {
            return _uruntDal.GetList();
        }

        public List<Urun> GetByCategory(int kategoryId)
        {
            return _uruntDal.GetList(x => x.KategoriId == kategoryId);
        }

        public Urun GetById(int urunId)
        {
            return _uruntDal.Get(x => x.UrunId == urunId);
        }

        public void Update(Urun urun)
        {
            _uruntDal.Update(urun);
        }
    }
}
