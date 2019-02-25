using System;
using System.Collections.Generic;

namespace Vega_1.Models
{
    public class Vehcel
    {
        public int ID { get; set; }
         public virtual ICollection<Make> Makes { get; set; }

    }
}