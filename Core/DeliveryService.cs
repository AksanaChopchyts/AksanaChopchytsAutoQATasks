using AksanaChopchytsAutoQATasks.Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksanaChopchytsAutoQATasks.Core
{
    public class DeliveryService
    {
        public string Name { get; }
        List<Order> _orders = new List<Order>();
        List<IDelivery> _deliveryProviders = new List<IDelivery>();
        public DeliveryService(string name)
        {
            Name = name;
        }

        public Order AddDelivery(string productName)
        {
            Order resultOrder = _orders.Where(order=>order.ProductName == productName).FirstOrDefault();
                           
            if (resultOrder != null)
            {
                _orders.Remove(resultOrder);
                return resultOrder;
            }

            return null;
        }

        public bool AddOrder(Order order)
        {
            _orders.Add(order);
            return true;
        }

        public void DeliverOrders()
        {
            foreach (var order in _orders)
            {
                var bestDelivery = _deliveryProviders.OrderBy(dp => dp.ExpectedDeliveryTime(order)).First();
                Console.WriteLine($"Order {order.ProductName} will be delivered by {bestDelivery.GetType().Name} in {bestDelivery.ExpectedDeliveryTime(order)}.");
                bestDelivery.DeliverOrder(order);
            }
            _orders.Clear();
        }

    }
}
