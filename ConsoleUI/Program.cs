using Businness.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal()) ;

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
