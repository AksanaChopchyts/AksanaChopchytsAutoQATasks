using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
