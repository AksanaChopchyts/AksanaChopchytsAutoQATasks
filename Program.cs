// See https://aka.ms/new-console-template for more information
using AksanaChopchytsAutoQATasks;


Order[] orders = {new Order ("Ice-cream", 3752961111116, 3f, "Timiryazev St"),
                  new Order ( "Milk", 3752951111115, 5f, "Orlovskay St"),
                  new Order ("Whyskey", 3721111111112, 25f,"Sedova St"),
                  new Order ("Whysk", 3721111111112, 15f,"Sedova St")};


Console.WriteLine(" - - - Task #2 All items - - - ");

foreach (Order oder in orders)
{
    Console.WriteLine(oder.GetFullInfo());
}

Console.WriteLine(" - - - Task #2.4 - - - ");

foreach (Order order in orders)
{
    if (order.PhoneNumber.ToString().StartsWith("375"))
    {
        Console.WriteLine(order.GetFullInfo());
    }
}

Console.WriteLine(" - - - Task #2.5 - - - ");

foreach (Order order in orders)
{
    if (order.Cost < 20 && order.ProductName.ToString().StartsWith("Whys"))
    {
        Console.WriteLine(order.GetFullInfo());
    }
}
