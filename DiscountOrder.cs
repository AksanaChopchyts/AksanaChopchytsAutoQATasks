namespace AksanaChopchytsAutoQATasks
{
    internal class DiscountOrder: Order
    {
        public float Discount { get; set; }
        public DiscountOrder(string productName, long phoneNumber, float cost, string deliveryAddress, float discount) : base(productName, phoneNumber, cost, deliveryAddress)
        {
            Discount = discount;
        }
        public override string GetFullInfo()
        {
            return $"DiscountOrder: ProductName: {ProductName}, PhoneNumber: {PhoneNumber}, Cost: {Cost}, DeliveryAddress: {DeliveryAddress},  Discount: {Discount}%";
        }

    }
}
