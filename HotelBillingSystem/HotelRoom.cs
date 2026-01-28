using LuxeStay;
namespace LuxeStay
{
    public class HotelRoom : IRoom
    {
        string? roomType { get; set; }
        double ratePerNight { get; set; }
        string? guestName { get; set;}

        public HotelRoom(string roomType, double ratePerNight, string guestName)
        {
            this.roomType = roomType;
            this.ratePerNight = ratePerNight;
            this.guestName = guestName;
        }

        public int calculateMembershipYears(int joiningYear)
        {
            return (DateTime.Now.Year - joiningYear);
        }

        public string GetRoomType()
        {
            return roomType;
        }
        public double GetRatePerNight()
        {
            return ratePerNight;
        }

        public string GetGuestName()
        {
            return guestName;
        }
        public double calculateTotalBill(int nightsStayed, int joiningYear)
        {
            double bill =  nightsStayed * ratePerNight;

            int membershipYears = calculateMembershipYears(joiningYear);

            if (membershipYears > 3)
            {
                double discountRate = 0.1;
                bill -= bill * discountRate;
            }
            return Math.Round(bill,2);
        }

        public void PrintRoomSummary(int joiningYear)
        {
            int membershipYears = calculateMembershipYears(joiningYear);
            
            Console.WriteLine($"{roomType} Room:  {guestName}, {ratePerNight} per night, Membership: {membershipYears} years  ");
        }
    }
}