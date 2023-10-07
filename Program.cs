// See https://aka.ms/new-console-template for more information
using AksanaChopchytsAutoQATasks;


Order[] orders = {new Order ("Ice-cream", 3752961111116, 3f, "Timiryazev St"),
                  new Order ( "Milk", 3752951111115, 5f, "Orlovskay St"),
                  new Order ("Whyskey", 3721111111112, 25f,"Sedova St") };

foreach (Order oder in orders)
{
    Console.WriteLine(oder.GetFullInfo());
}
                                       