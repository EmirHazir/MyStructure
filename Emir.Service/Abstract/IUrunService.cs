using Emir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir.Service.Abstract
{
   public interface IUrunService
    {
        List<Urun> GetAll();

        List<Urun> GetByCategory(int kategoryId);

        void Add(Urun urun);

        void Update(Urun urun);

        void Delete(int urunId);

        Urun GetById(int urunId);
    }
}
