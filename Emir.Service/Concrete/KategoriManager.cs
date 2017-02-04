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
    public class KategoriManager : IKategoriService
    {
        private IKategoriDal _kategoryDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoryDal = kategoriDal;
        }
             

        public void Add(Kategori kategori)
        {
            _kategoryDal.Add(kategori);
        }

        public void Delete(int kategoriId)
        {
            _kategoryDal.Delete(new Kategori { KategoriId = kategoriId });
        }

        public List<Kategori> GetAll()
        {
            return _kategoryDal.GetList();
        }

        public Kategori GetById(int kategoriId)
        {
            return _kategoryDal.Get(x => x.KategoriId == kategoriId);
        }

        public void Update(Kategori kategori)
        {
            _kategoryDal.Update(kategori);
        }
    }
}
