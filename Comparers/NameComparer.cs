using AksanaChopchytsAutoQATasks.Core;

namespace AksanaChopchytsAutoQATasks.Comparers
{
    public class OrderByNameComparer : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            return x.ProductName.CompareTo(y.ProductName);
        }
    }
}
