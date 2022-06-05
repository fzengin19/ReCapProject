using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {

        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Ford" });
            brandManager.Add(new Brand { BrandName = "Mazda" });
            brandManager.Add(new Brand { BrandName = "Honda" });
            brandManager.Add(new Brand { BrandName = "Fiat" });
            Console.WriteLine("Eklenen Markalar");
            foreach (var car in brandManager.GetBrands())
            {
                Console.WriteLine(car.BrandName);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ColorManager carColorManager = new ColorManager(new EfCarColorDal());
            carColorManager.Add(new Color { ColorName = "Gri" });
            carColorManager.Add(new Color { ColorName = "Beyaz" });
            carColorManager.Add(new Color { ColorName = "Yeşil" });
            Console.WriteLine("Eklenen renkler");
            foreach (var car in carColorManager.GetColors())
            {
                Console.WriteLine(car.ColorName);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            CarManager carManager = new CarManager(new EfCarDal()); ;
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 80, Description = "Ford focus", ModelYear = 2001 });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "Ford fiesta", ModelYear = 2003 });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 90, Description = "Mazda rx-7", ModelYear = 2002 });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 60, Description = "Honda civic", ModelYear = 2002 });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 70, Description = "Fiat egea", ModelYear = 2005 });
            Console.WriteLine("Eklenen Arabalar");
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Marka id'si 1 olan arabaları getirdik");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description+" "+car.BrandId);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Color id'si 1 olan arabaları getidik");
            carManager.GetCarsByColorId(1);
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description + " " + car.ColorId);
            }

        }
    }
}