using Emir.Core.CoreEntityFramework;
using Emir.Dal.Abstract;
using Emir.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir.Dal.EntityFramework
{
    public class EfKullaniciDal : EfEntityRepositoryBase<Kullanici, EFDatabaseContext>, IKullaniciDal
    {
    }
}
