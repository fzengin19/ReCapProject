using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
                {
                    new Car{CarId=1,ModelYear=2000,Description="Ford focus",BrandId=1, ColorId=1,DailyPrice=100},
                    new Car{CarId=2,ModelYear=2001,Description="Ford fiesta",BrandId=1, ColorId=3,DailyPrice=120},
                    new Car{CarId=3,ModelYear=2002,Description="Honda civic",BrandId=2, ColorId=2,DailyPrice=80},
                    new Car{CarId=4,ModelYear=2003,Description="Fiat uno",BrandId=3, ColorId=1,DailyPrice=60},
                    new Car{CarId=5,ModelYear=2004,Description="Wolkswagen golf",BrandId=4, ColorId=2,DailyPrice=110}
                };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car c = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(c);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car car1 = _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            car1.DailyPrice = car.DailyPrice;
            car1.ModelYear = car.ModelYear;
            car1.BrandId = car.BrandId;
            car1.Description = car.Description;
            car1.ColorId = car.ColorId;
        }
    }
}
