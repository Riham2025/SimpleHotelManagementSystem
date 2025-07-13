namespace SimpleHotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Room room1 = new Room(102);
            



                Console.WriteLine($"Room Number: {room1.RoomNumber}, IsBooked: {room1.IsBooked}");
                room1.Book();
                Console.WriteLine($"After booking - IsBooked: {room1.IsBooked}");
            

            Guest guest1 = new Guest("Sara", "ID123456789" , "StrongPassword123");
            
                
                Console.WriteLine($"Guest Name: {guest1.Name}, National ID: {guest1.NationalID} ,  Password : {guest1.Password}");
            

        }
    }
}
