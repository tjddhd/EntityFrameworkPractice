using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeEF.Models
{
    public class Manufacturer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ManufacturerID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}