using AksanaChopchytsAutoQATasks.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksanaChopchytsAutoQATasks.Delivery
{
    public class WalkDelivery : IDelivery
    {
        public void DeliveryOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} is being delivered by foot."); // Реализация доставки пешим доставщиком
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(30); // Время доставки для пешего доставщика
        }
    }
}
