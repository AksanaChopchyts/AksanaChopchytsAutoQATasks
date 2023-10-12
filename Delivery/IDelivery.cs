using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AksanaChopchytsAutoQATasks.Core;

namespace AksanaChopchytsAutoQATasks.Delivery
{
    interface IDelivery
    {
        void DeliverOrder(Order order);
        TimeSpan ExpectedDeliveryTime(Order order);
    }
}
