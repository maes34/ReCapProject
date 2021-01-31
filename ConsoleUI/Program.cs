using Businness.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal()) ;

            // Yeni Araç
            Car car1 = new Car() { Id = 6, BrandId = 3, ColorId = 2, DailyPrice = 100, Description = "Deneme", ModelYear = "1994" };
            carManager.Add(car1);
            

            foreach (var x in carManager.GetAll())
            {
                Console.WriteLine("Marka : " + x.BrandId);
                Console.WriteLine("Renk : " + x.ColorId);
                Console.WriteLine("Model : " + x.ModelYear);
                Console.WriteLine("Günlük Ücret : " + x.DailyPrice);
                Console.WriteLine("Açıklama : " + x.Description);
                Console.WriteLine("---------------------------------");
            }

           

        }
    }
}
