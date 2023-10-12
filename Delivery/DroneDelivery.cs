using AksanaChopchytsAutoQATasks.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksanaChopchytsAutoQATasks.Delivery
{
    public class DroneDelivery : IDelivery
    {
        public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} is being delivered by drone.");// Реализация авто-доставки
        }

        public TimeSpan ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(10);// Время доставки для авто-доставщика
        }
    }
}
