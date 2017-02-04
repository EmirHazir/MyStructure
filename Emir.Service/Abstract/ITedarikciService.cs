using Emir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir.Service.Abstract
{
   public interface ITedarikciService
    {
        List<Tedarikci> GetAll();

        void Add(Tedarikci tedarikci);

        void Update(Tedarikci tedarikciId);

        void Delete(int tedarikciId);

        Tedarikci GetById(int tedarikciId);
    }
}
