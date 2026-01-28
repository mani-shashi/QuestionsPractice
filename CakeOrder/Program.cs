namespace CakeOrder
{
    public class Program
    {
        public static void Main()
        {
            CakeOrder cake = new CakeOrder();

            Console.WriteLine("Enter Number of Cake you want to Enter");
            int.TryParse(Console.ReadLine(), out int numberOfCake);

            Console.WriteLine("Enter Cake Details (in this format) : {OrderID:CakeCost}");

            for(int i = 0; i < numberOfCake; i++)
            {
                string? input = Console.ReadLine();
                string [] stringArr = input.Split(':');
                string orderId = stringArr[0];
                double cakeCost = double.Parse(stringArr[1]);
                cake.addOrderDetails(orderId,cakeCost);
            }
            
            Console.WriteLine("Enter the Cost to search the cake orders: ");
            double.TryParse(Console.ReadLine(), out double costOfCake);

            Dictionary<string, double> result = cake.findTheOrderAboveSpecificCost(costOfCake);

            Console.WriteLine("Cake Orders above the specified cost");
            foreach(var item in result)
            {
                Console.WriteLine($"Order ID : {item.Key}, Cake Cost : {item.Value}");
            }
        }
    }
}