using Microsoft.EntityFrameworkCore;
using MondayFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayFirst.Entities
{
    public class LogContext : DbContext
    {
        public LogContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Log> Logs { get; set; }
    }
}
