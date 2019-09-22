using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeEF.Models
{
        public enum Color
        {
            Red, Black, Blue, Green, White, Silver
        }

        public class Car
        {
            public int CarID { get; set; } //VIN
            public int ManufacturerID { get; set; }
            public int DriverID { get; set; }
            public bool Salvaged { get; set; }
            public bool ManualTransmission { get; set; }
            public string Model { get; set; }
            public Color? Color { get; set; }

            public virtual Manufacturer Manufacturer { get; set; }
            public virtual Driver Driver { get; set; }
        }
}