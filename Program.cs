// See https://aka.ms/new-console-template for more information
using AksanaChopchytsAutoQATasks;
using AksanaChopchytsAutoQATasks.Comparers;
using System.Collections.Generic;
using System.Linq;

List<Order> orders = new List<Order>();
orders.Add(new OrdinaryOrder("Ice-cream", 3752961111116, 3f, "Timiryazev St"));
orders.Add(new OrdinaryOrder("Milk", 3752951111115, 5f, "Orlovskay St"));
orders.Add(new OrdinaryOrder("Milk", 3752951111115, 5f, "Sedova St"));
orders.Add(new OrdinaryOrder("Whyskey", 3721111111112, 101f, "Sedova St"));
orders.Add(new OrdinaryOrder("Whysk", 3721111111112, 15f, "Sedova St"));
orders.Add(new DiscountOrder("Mouse", 3751234567892, 25f, "Orlovskay St", -10f));
orders.Add(new VIPOrder("Laptop", 3751234567890, 900f, "Timiryazev St", "Cover"));

var sortedByName = orders.OrderBy(order => order.ProductName);
var sortedByCost = orders.OrderBy(order => order.Cost);
var sortedByAddress = orders.OrderBy(order => order.DeliveryAddress);

var affordable_Products = orders
    .Where(order => order.Cost <= 100)
    .OrderBy(order => order.ProductName)
    .Select(productName => productName);

foreach (var productName in affordable_Products)
{
    Console.WriteLine(productName);
}

// Works if we have only 1!!! the most common product on the order list
var mostFrequentProduct = orders
    .GroupBy(orders => orders.ProductName)
    .OrderByDescending(group => group.Count())
    .Select(group => group.Key)
    .First();

Console.WriteLine("Most frequent product: " + mostFrequentProduct); 