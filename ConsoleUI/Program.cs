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

            ReadConsole();

        }
        private static async void ReadConsole()
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "Start")
                {
                    CarManager carManager = new CarManager(new EfCarDal());
                    foreach (var carDetail in carManager.GetCarDetails().Data)
                    {
                        Console.WriteLine(carDetail.Description + "//    Marka: " + carDetail.BrandName + "//   Renk: " + carDetail.ColorName);
                    }
                }
            }
        }
    }
}