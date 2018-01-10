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
                Balance = "0",
                UserType = "Professor"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Barnabas",
                Balance = "-30",
                UserType = "Student"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Lena",
                Balance = "0",
                UserType = "Child"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Benedek",
                Balance = "-50",
                UserType = "Teacher"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Zorka",
                Balance = "2000",
                UserType = "Director"
            });
        }
    }
}
