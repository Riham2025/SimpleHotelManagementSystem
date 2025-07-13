using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem
{
    // Represents a booking between a guest and a room
    class Booking
    {
        private Room room;
        private Guest guest;

        // Read-only property for booking time
        public DateTime BookingTime { get; private set; }
    }
}
