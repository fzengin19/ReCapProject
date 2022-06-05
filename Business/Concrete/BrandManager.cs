using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(EfBrandDal efBrandDal)
        {
            _brandDal = efBrandDal;
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public List<Brand> GetBrands()
        {
            return _brandDal.GetAll().ToList();
        }
    }
}
