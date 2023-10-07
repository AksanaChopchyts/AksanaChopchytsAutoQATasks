// See https://aka.ms/new-console-template for more information
using AksanaChopchytsAutoQATasks;


Order[] orders = {new OrdinaryOrder ("Ice-cream", 3752961111116, 3f, "Timiryazev St"),
                  new OrdinaryOrder ( "Milk", 3752951111115, 5f, "Orlovskay St"),
                  new OrdinaryOrder ("Whyskey", 3721111111112, 25f,"Sedova St"),
                  new OrdinaryOrder ("Whysk", 3721111111112, 15f,"Sedova St"),
                  new VIPOrder ("Laptop", 3751234567890, 900f, "Timiryazev St","Cover"),
                  new DiscountOrder ("Mouse", 3751234567892, 25f, "Orlovskay St", -10f)};


Console.WriteLine(" - - - Task #3 All items - - - ");

foreach (Order oder in orders)
{
    Console.WriteLine(oder.GetFullInfo());
}
