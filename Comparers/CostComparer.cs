using AksanaChopchytsAutoQATasks.Core;

namespace AksanaChopchytsAutoQATasks.Comparers
{
    public class OrderByCostComparer : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            return x.Cost.CompareTo(y.Cost);
        }
    }
}
