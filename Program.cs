namespace SimpleHotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Room room1 = new Room(100);


            Console.WriteLine($"Room Number: {room1.RoomNumber}, IsBooked: {room1.IsBooked}");
            room1.Book();
            Console.WriteLine($"After booking - IsBooked: {room1.IsBooked}");

        }
    }
}
