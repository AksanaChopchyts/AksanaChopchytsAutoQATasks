// See https://aka.ms/new-console-template for more information
using AksanaChopchytsAutoQATasks;
using AksanaChopchytsAutoQATasks.Comparers;


List<Order> orders = new List<Order>();
orders.Add(new OrdinaryOrder("Ice-cream", 3752961111116, 3f, "Timiryazev St"));
orders.Add(new OrdinaryOrder("Milk", 3752951111115, 5f, "Orlovskay St"));
orders.Add(new OrdinaryOrder("Milk", 3752951111115, 5f, "Sedova St"));
orders.Add(new OrdinaryOrder("Whyskey", 3721111111112, 101f, "Sedova St"));
orders.Add(new OrdinaryOrder("Whysk", 3721111111112, 15f, "Sedova St"));
orders.Add(new DiscountOrder("Mouse", 3751234567892, 25f, "Orlovskay St", -10f));
orders.Add(new VIPOrder("Laptop", 3751234567890, 900f, "Timiryazev St", "Cover"));

var orderByNameComparer = new OrderByNameComparer();
orders.Sort(orderByNameComparer);

Console.WriteLine("Sorted by Name:");
foreach (var order in orders)
{
    Console.WriteLine(order.GetFullInfo());
}

var orderByCostComparer = new OrderByCostComparer();
orders.Sort(orderByCostComparer);

Console.WriteLine("Sorted by Cost:");
foreach (var order in orders)
{
    Console.WriteLine(order.GetFullInfo());
}

var orderByAddressComparer = new OrderByDeliveryAddressComparer();
orders.Sort(orderByAddressComparer);

Console.WriteLine("Sorted by Address:");
foreach (var order in orders)
{
    Console.WriteLine(order.GetFullInfo());
}
