using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
