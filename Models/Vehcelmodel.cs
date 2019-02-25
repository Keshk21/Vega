using System;

namespace Vega_1.Models
{
    public class VehcelModel
    {
        public int Id { get; set; }
        public DateTime Modelyear { get; set; }
        public VehcelModel vehcelModel { get; set; }
    }
}