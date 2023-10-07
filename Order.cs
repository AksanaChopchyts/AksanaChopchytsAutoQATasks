namespace AksanaChopchytsAutoQATasks
{
    internal class Order
    {
        public string ProductName;
        public long PhoneNumber;
        public float Cost;
        public string DeliveryAddress;
        public Order(string productName, long phoneNumber, float cost, string deliveryAddress)
        {
            ProductName = productName;
            PhoneNumber = phoneNumber;
            Cost = cost;
            DeliveryAddress = deliveryAddress;
        }
        public string GetFullInfo()
        {
            return $"Product Name:{ProductName}, PhoneNumber:{PhoneNumber}, Cost:{Cost}, DeliveryAddress: {DeliveryAddress}";
            
        }
    }
}
