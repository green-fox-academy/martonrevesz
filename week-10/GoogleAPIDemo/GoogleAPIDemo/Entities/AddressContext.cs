using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using GoogleAPIDemo.Models;

namespace GoogleAPIDemo.Entities
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
    }
}
