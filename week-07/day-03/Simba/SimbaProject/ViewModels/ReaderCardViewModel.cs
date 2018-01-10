using SimbaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaProject.ViewModels
{
    public class ReaderCardViewModel
    {
        public List<ReaderCard> ReaderList = new List<ReaderCard>();

        public ReaderCardViewModel()
        {
            InitReaderCardList();
        }

        private void InitReaderCardList()
        {
            ReaderList.Add(new ReaderCard()
            {
                Name = "Gerzson",
                Fine = 0,
                UserType = "Professor",
                VIP = true
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Barnabas",
                Fine = 30,
                UserType = "Student"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Lena",
                Fine = 0,
                UserType = "Child"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Benedek",
                Fine = 50,
                UserType = "Teacher"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Zorka",
                Fine = 20,
                UserType = "Director",
                VIP = true
            });
        }
    }
}
