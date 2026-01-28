namespace CakeOrder
{
    public class CakeOrder
    {
        public string? OrderId{get; set;}
        public double CakeCost{get; set;}
        public CakeOrder(){}
        public CakeOrder(string orderId, double cakeCost)
        {
            OrderId = orderId;
            CakeCost = cakeCost;
        }
        private static SortedDictionary<string, double> sortedMap = new SortedDictionary<string, double>();

        public void addOrderDetails(string orderId, double cakeCost)
        {
            if (sortedMap.ContainsKey(orderId))
            {
                Console.WriteLine("Cake Already Present");
            }
            sortedMap[orderId] = cakeCost;
        }
        public Dictionary<string, double> findTheOrderAboveSpecificCost(double cakeCost)
        {
            Dictionary<string, double> res = new Dictionary<string, double>();
            foreach (var item in sortedMap)
            {
                if(item.Value > cakeCost)
                {
                    res[item.Key] = item.Value;
                }
            }
            return res;
        }
    }
}