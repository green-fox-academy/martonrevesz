using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.Models
{
    public class ReaderCard
    {
        public static int counter = 0;

        public int Id { get; set; }

        [Required]
        public string Name{ get; set; }
        public int Fine { get; set; }
        public string UserType { get; set; }
        public bool VIP { get; set; }

        public ReaderCard()
        {
            Id = counter++;
        }
    }
}
