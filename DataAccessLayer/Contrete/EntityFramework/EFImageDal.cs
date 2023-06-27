using DataAccessLayer.Abstract;
using DataAccessLayer.Contrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contrete.EntityFramework
{
    public class EFImageDal:GenericRepository<Image>, IImageDal
    {
    }
}
