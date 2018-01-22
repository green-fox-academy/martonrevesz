using MondayFirst.Entities;
using MondayFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayFirst.Services
{
    public class LogService
    {
        public LogService(LogRepository logRepository)
        {
            LogRepository = logRepository;
        }

        public LogRepository LogRepository { get; set; }



        public void LogIndex()
        {
            LogRepository.LogIndex();
        }
    }
}
