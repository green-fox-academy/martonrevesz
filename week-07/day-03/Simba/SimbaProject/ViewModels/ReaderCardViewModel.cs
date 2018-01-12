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
                Name = "Süvi",
                Fine = 0,
                UserType = "Mentor",
                VIP = true
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Gabor",
                Fine = 30,
                UserType = "mentor"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Misi",
                Fine = 0,
                UserType = "student"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Samu",
                Fine = 50,
                UserType = "partner"
            });
            ReaderList.Add(new ReaderCard()
            {
                Name = "Balint",
                Fine = 20,
                UserType = "student",
                VIP = true
            });
        }
    }
}
