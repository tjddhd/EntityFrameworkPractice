using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PracticeEF.Models;

namespace PracticeEF.DriverDAL
{
    public class MarketInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MarketContext>
    {
        protected override void Seed(MarketContext context)
        {
            //base.Seed(context);

            var drivers = new List<Driver>
            {
                new Driver{FirstName="Thomas",LastName="Smith",Age=27,ID=123123123},
                new Driver{FirstName="Jodie",LastName="Smith",Age=25,ID=456456456},
                new Driver{FirstName="Peter",LastName="Smith",Age=23,ID=789789789},
                new Driver{FirstName="Tiffany",LastName="Brown",Age=28,ID=147147147}
            };

            drivers.ForEach(d => context.Drivers.Add(d));
            context.SaveChanges();

            var manufacturers = new List<Manufacturer>
            {
                new Manufacturer{ManufacturerID=123,Name="Toyota"},
                new Manufacturer{ManufacturerID=456,Name="Dodge"},
                new Manufacturer{ManufacturerID=789,Name="Saturn"}
            };

            manufacturers.ForEach(m => context.Manufacturers.Add(m));
            context.SaveChanges();

            var cars = new List<Car>
            {
                new Car{CarID=111222333,Model="Corolla",DriverID=123123123,ManufacturerID=123,ManualTransmission=true,Color=Color.White},
                new Car{CarID=444555666,Model="RAV4",DriverID=147147147,ManufacturerID=123,ManualTransmission=false,Color=Color.Red},
                new Car{CarID=777888999,Model="SC1",DriverID=123123123,ManufacturerID=789,Color=Color.Black},
                new Car{CarID=999888777,Model="Neon",DriverID=456456456,ManufacturerID=456,Color=Color.Silver},
                new Car{CarID=666555444,Model="Corolla",DriverID=789789789,ManufacturerID=123,Color=Color.Blue},
                new Car{CarID=333222111,Model="Ram",DriverID=456456456,ManufacturerID=456,Color=Color.Black,Salvaged=true},
            };

            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();
        }
    }
}