using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EvanasGarden.Models
{
    public class EvanasGardenDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public EvanasGardenDbContext()
        {

        }
    }
}