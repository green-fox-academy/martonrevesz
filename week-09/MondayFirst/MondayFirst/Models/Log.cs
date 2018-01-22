using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MondayFirst.Models
{
    public class Log
    {
        [Key]
        public int? Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Endpoint { get; set; }
        public string Data { get; set; }
    }
}
