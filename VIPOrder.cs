namespace AksanaChopchytsAutoQATasks
{
    internal class VIPOrder: Order
    {
        public string Gift {  get; set; }

        public VIPOrder(string productName, long phoneNumber, float cost, string deliveryAddress, string gift): base(productName, phoneNumber, cost, deliveryAddress)
        {
            Gift = gift;
        }

        public override string GetFullInfo()
        {
            return $"VIPOrder: Product Name: {ProductName}, PhoneNumber: {PhoneNumber}, Cost: {Cost}, DeliveryAddress: {DeliveryAddress}, Gift: {Gift}";
        }
    }
}
