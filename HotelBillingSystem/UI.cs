using System.Runtime.ConstrainedExecution;

namespace LuxeStay
{
    public class UI
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nEnter Deluxe Room Details: ");
            Console.WriteLine("\nGuest Name: ");
            string? deluxeGuestName = Console.ReadLine();
            Console.WriteLine("Rate per Night: ");
            int.TryParse(Console.ReadLine(), out int deluxeRate);
            Console.WriteLine("Nights Stayed: ");
            int.TryParse(Console.ReadLine(), out int deluxeNights);
            Console.WriteLine("Joining Year: ");
            int.TryParse(Console.ReadLine(), out int deluxeYear);

            HotelRoom deluxeRoom = new HotelRoom("Deluxe", deluxeRate, deluxeGuestName);

            Console.WriteLine("\nEnter Suite Room Details: ");
            Console.WriteLine("\nSuite Name: ");
            string? suiteGuestName = Console.ReadLine();
            Console.WriteLine("Rate per Night: ");
            int.TryParse(Console.ReadLine(), out int suiteRate);
            Console.WriteLine("Nights Stayed: ");
            int.TryParse(Console.ReadLine(), out int suiteNights);
            Console.WriteLine("Joining Year: ");
            int.TryParse(Console.ReadLine(), out int suiteYear);

            HotelRoom suiteRoom = new HotelRoom("Suite", suiteRate, suiteGuestName);

            Console.WriteLine("\nRoom Summary:");
            deluxeRoom.PrintRoomSummary(deluxeYear);
            suiteRoom.PrintRoomSummary(suiteYear);


            Console.WriteLine("\nTotal Bill:");
            Console.WriteLine($"For {deluxeGuestName} ({deluxeRoom.roomType}): {deluxeRoom.calculateTotalBill(deluxeNights,deluxeYear)}");
            Console.WriteLine($"For {suiteGuestName} ({deluxeRoom.roomType}): {suiteRoom.calculateTotalBill(suiteNights,suiteYear)}");
        }
    }
}