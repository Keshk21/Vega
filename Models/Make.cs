using System.Collections.Generic;

namespace Vega_1.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string MakeName {get; set;}
         public virtual ICollection<VehcelModel> VehcelModels { get; set; }
         public Vehcel Vehcel { get; set; }            

    }
}