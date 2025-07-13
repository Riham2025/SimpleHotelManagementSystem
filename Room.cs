using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace SimpleHotelManagementSystem
{
    // Represents a hotel room
    public class Room // Declares a public class named Room that can be used anywhere in the project

    {

        // Private fields
        private int roomNumber; //These are private fields — internal variables that store the room’s number and whether it is booked.
        private bool isBooked; //They are not directly accessible from outside the class (because of private).

        // Static field to track total rooms
        private static int roomCount = 0; //This is a static field — shared by all Room objects.
                                          //  It tracks how many rooms have been created in total.
                                          //It starts at 0 and increases when a room is created.

        // Property to get room number
        public int RoomNumber // This is a public property to expose the private roomNumber
                              //Properties allow controlled access to fields (using get and set).

        {
            get { return roomNumber; }  //get: Allows other code to read the room number.
            private set  //private set: Only the class itself can set the value.
            {
                if (value >= 100) // Inside set, there is validation: room number must be 100 or more, or it throws an error.
                    roomNumber = value;
                else
                    throw new ArgumentException("Room number must be 100 or greater.");
            }
        }

        // Property to get booking status
        public bool IsBooked // A read-only public property to know if the room is booked.
        {
            get { return isBooked; } //There is no set, so you can't change it from outside.
        }

        // Constructor with parameter
         public Room(int number) //A constructor runs when you create a new Room object.
                                 //  It accepts one argument number, which is the room number.
        {
            RoomNumber = number; //Assigns the room number (with validation from the property).
            isBooked = false; //Sets isBooked to false (room is available by default).
            roomCount++; // Increments roomCount to track how many rooms have been created.

        }

        // Method to book the room
        public void Book()
        {
            isBooked = true; //A method that marks the room as booked by setting isBooked = true
        }

        // Method to free the room
        public void Free()
        {
            isBooked = false; // A method that marks the room as available by setting isBooked = false.
        }


        // Static method to get total room count
        public static int GetRoomCount() //A static method that returns the value of the shared static field roomCount.
        {
            return roomCount;
        }
    }


}
}
