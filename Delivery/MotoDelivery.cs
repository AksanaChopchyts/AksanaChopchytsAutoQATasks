using AksanaChopchytsAutoQATasks.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksanaChopchytsAutoQATasks.Delivery
{
    public class MotoDelivery : IDelivery
    {
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} is being delivered by motobike."); // Реализация мото-доставки
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(20); // Время доставки для мото-доставщика
        }
    }
}
