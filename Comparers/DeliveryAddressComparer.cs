using AksanaChopchytsAutoQATasks.Core;

namespace AksanaChopchytsAutoQATasks.Comparers
{
    public class OrderByDeliveryAddressComparer : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            return x.DeliveryAddress.CompareTo(y.DeliveryAddress);
        }
    }
}
