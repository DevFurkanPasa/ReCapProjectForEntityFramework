using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetail())
            {
                Console.WriteLine(item.ColorName +" "+ item.BrandName + " => " + item.DailyPrice );
            }




        }
    }
}
