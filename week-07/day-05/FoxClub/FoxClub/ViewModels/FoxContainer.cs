using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.ViewModels
{
    public class FoxContainer
    {
        public List<Fox> FoxList { get; set; } = new List<Fox>();

        public FoxContainer()
        {
            InitializeList();
        }

        private void InitializeList()
        {
            FoxList.Add( new Fox() { Name = "Vuk", Drink="coctail" });
            FoxList.Add( new Fox() { Name = "Fox" });
            FoxList.Add( new Fox() { Name = "Roka" });
        }
    }
}
