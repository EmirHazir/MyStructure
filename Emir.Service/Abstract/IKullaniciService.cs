using Emir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir.Service.Abstract
{
   public interface IKullaniciService
    {
        List<Kullanici> GetAll();

        void Add(Kullanici kullanici);

        void Update(Kullanici kullanici);

        void Delete(int kullaniciId);

        Kullanici GetById(int kullaniciId);
    }
}
