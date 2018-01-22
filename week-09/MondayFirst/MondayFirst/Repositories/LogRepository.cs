using MondayFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayFirst.Repositories
{
    public class LogRepository
    {
        public LogRepository(LogContext logContext)
        {
            LogContext = logContext;
        }

        public LogContext LogContext { get; set; }

        public void LogIndex()
        {
            LogContext.Logs.Add(new Log() { Endpoint = "", Data = "" });
            LogContext.SaveChanges();
        }
    }
}
