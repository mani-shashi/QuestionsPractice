namespace LuxeStay
{
    interface IRoom
    {
        double calculateTotalBill(int nightsStayed, int joiningYear);

        public int calculateMembershipYears(int joiningYear);
    }
}