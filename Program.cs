// See https://aka.ms/new-console-template for more information
using AksanaChopchytsAutoQATasks;

/*List<Order> orders = new List<Order>(){new OrdinaryOrder ("Ice-cream", 3752961111116, 3f, "Timiryazev St"),
                                         new OrdinaryOrder ( "Milk", 3752951111115, 5f, "Orlovskay St"),
                                         new OrdinaryOrder ("Whyskey", 3721111111112, 25f,"Sedova St"),
                                         new OrdinaryOrder ("Whysk", 3721111111112, 15f,"Sedova St"),
                                         new VIPOrder ("Laptop", 3751234567890, 900f, "Timiryazev St","Cover"),
                                         new DiscountOrder ("Mouse", 3751234567892, 25f, "Orlovskay St", -10f)};*/

MyList<Order> orders = new MyList<Order>();
orders.Add(new OrdinaryOrder("Ice-cream", 3752961111116, 3f, "Timiryazev St"));
orders.Add(new OrdinaryOrder("Milk", 3752951111115, 5f, "Orlovskay St"));
orders.Add(new OrdinaryOrder("Whyskey", 3721111111112, 25f, "Sedova St"));
orders.Add(new OrdinaryOrder("Whysk", 3721111111112, 15f, "Sedova St"));
orders.Add(new DiscountOrder("Mouse", 3751234567892, 25f, "Orlovskay St", -10f));
orders.Add(new VIPOrder("Laptop", 3751234567890, 900f, "Timiryazev St", "Cover"));


Console.WriteLine(" - - - Task #4.3 All items - - - ");

foreach (var order in orders)
{
    Console.WriteLine(order.GetFullInfo());
}


//for (int i = 0; i < orders.GetCount(); i++)
//{
//    Console.WriteLine(orders.GetElementByPosition(i));
//}
