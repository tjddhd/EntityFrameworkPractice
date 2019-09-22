using System;
using System.Collections.Generic;

namespace PracticeEF.Models
{
    public class Driver
    {
        public int ID { get; set; } //SSN
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}