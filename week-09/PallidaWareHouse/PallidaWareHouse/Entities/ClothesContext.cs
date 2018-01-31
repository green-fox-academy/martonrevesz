using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using PallidaWareHouse.Models;

namespace PallidaWareHouse.Entities
{
    public class ClothesContext : DbContext
    {
        public ClothesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Clothing> Clothes { get; set; }
    }
}
