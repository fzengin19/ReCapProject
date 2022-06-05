using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetCars()
        {
            return _carDal.GetAll();
        }
        public void Add(Car car)
        {
            if (car.DailyPrice<=0)
            {
                throw new Exception("Arabanın günlük ücreti 0'dan büyük olmalıdır!!");
            }
            if (car.Description.Length<2)
            {
                throw new Exception("Arabanın açıklaması en az 2 karakter olmalıdır!!");
            }
            _carDal.Add(car);
        }
        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId==brandId);
        }
        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }
    }
}
