using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class Reservation : IReservation
    {
        Random random = new Random();

        public string GetCodeBooking()
        {
            var options = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var code = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                code += options[random.Next(26)];
            }
            return code;
        }

        public string GetDowBooking()
        {
            string[] days = {"MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
            return days[random.Next(7)];
        }
    }
}
