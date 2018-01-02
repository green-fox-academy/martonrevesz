
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            var reservation = new Reservation();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Booking# {reservation.GetCodeBooking()} for {reservation.GetDowBooking()}");
            }
            Console.ReadLine();
        }
    }
}
