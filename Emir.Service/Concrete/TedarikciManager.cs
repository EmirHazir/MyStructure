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
    public class TedarikciManager : ITedarikciService
    {
        private ITedarikciDal _tedarikciDal;
        public TedarikciManager(ITedarikciDal tedarikciDal)
        {
            _tedarikciDal = tedarikciDal;
        }



        public void Add(Tedarikci tedarikci)
        {
            _tedarikciDal.Add(tedarikci);
        }

        public void Delete(int tedarikciId)
        {
            _tedarikciDal.Delete(new Tedarikci { TedarikciId = tedarikciId });
        }

        public List<Tedarikci> GetAll()
        {
            return _tedarikciDal.GetList();
        }

        public Tedarikci GetById(int tedarikciId)
        {
            return _tedarikciDal.Get(x => x.TedarikciId == tedarikciId);
        }

        public void Update(Tedarikci tedarikciId)
        {
            _tedarikciDal.Update(tedarikciId);
        }
    }
}
