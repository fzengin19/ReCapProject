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
            CarManager carManager = new CarManager(new EfCarDal());
            //Console.WriteLine("Marka id'si 1 olan arabaları getirdik");
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.Description+" BrandId:"+car.BrandId);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Color id'si 1 olan arabaları getidik");
            //carManager.GetCarsByColorId(1);
            //foreach (var car in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(car.Description + " ColorId:" + car.ColorId);
            //}

            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetail.Description+"//    Marka: "+carDetail.BrandName+"//   Renk: "+carDetail.ColorName);
            }
           

        }
    }
}