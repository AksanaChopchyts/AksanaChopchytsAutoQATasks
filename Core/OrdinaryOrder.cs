namespace AksanaChopchytsAutoQATasks.Core
{
    internal class OrdinaryOrder: Order
    {
        public string Ordinary {  get; set; }

        public OrdinaryOrder(string productName, long phoneNumber, float cost, string deliveryAddress) : base(productName, phoneNumber, cost, deliveryAddress) 
        {
        }
        public override string GetFullInfo()
        {
            return $"OrdinaryOrder: Product Name:{ProductName}, PhoneNumber:{PhoneNumber}, Cost:{Cost}, DeliveryAddress: {DeliveryAddress}";
        }
    }
}
