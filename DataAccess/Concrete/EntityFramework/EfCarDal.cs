using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
     public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
     {
        public EfCarDal()
        {
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from brand in context.Brands
                             join car in context.Cars on
                             brand.BrandId equals car.BrandId
                             join color in context.Colors on
                             car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 Id = car.CarId,
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                             };
                return result.ToList();
            }
        }
     }
}
