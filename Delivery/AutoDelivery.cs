using AksanaChopchytsAutoQATasks.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksanaChopchytsAutoQATasks.Delivery
{
    public class AutoDelivery : IDelivery
    {
         public void DeliverOrder(Order order)
        {
            Console.WriteLine($"Order {order.ProductName} is being delivered by car."); // Реализация авто-доставки
        }

        TimeSpan IDelivery.ExpectedDeliveryTime(Order order)
        {
            return TimeSpan.FromMinutes(15); // Время доставки для авто-доставщика
        }
    }
}
