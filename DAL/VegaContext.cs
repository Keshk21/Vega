using Microsoft.EntityFrameworkCore;
using System;
using Vega_1.Models;


namespace Vega_1.DAL
{
    public class VegaContext: DbContext
    {
        public VegaContext():base ()
        {

        }
    public DbSet<Vehcel> vehcels {get; set;}
        public DbSet<VehcelModel> VehcelModels {get; set;}

    public DbSet<Make> Makes {get; set;}

    }
}