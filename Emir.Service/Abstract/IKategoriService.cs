using Emir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir.Service.Abstract
{
   public interface IKategoriService
    {
        List<Kategori> GetAll();

        void Add(Kategori kategori);

        void Update(Kategori kategori);

        void Delete(int kategoriId);

        Kategori GetById(int kategoriId);
    }
}
