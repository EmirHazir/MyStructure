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
    public class KullaniciManager : IKullaniciService
    {

        private IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public void Add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }

        public void Delete(int kullaniciId)
        {
            _kullaniciDal.Delete(new Kullanici { KullaniciId = kullaniciId });
        }

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetList();
        }

        public Kullanici GetById(int kullaniciId)
        {
            return _kullaniciDal.Get(x => x.KullaniciId == kullaniciId && x.IsActive==true);
        }

        public void Update(Kullanici kullanici)
        {
            _kullaniciDal.Update(kullanici);
        }
    }
}
