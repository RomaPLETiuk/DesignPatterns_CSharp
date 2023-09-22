
using Proxy;

IChief chief = new ProxyChief(new Chief());

while(true)
{
    Thread.Sleep(1000);

    Console.Clear();

    Console.WriteLine("--Welcome--\n");
    Console.WriteLine("=====Orders=====\n");

    IEnumerable<Order> orders = chief.GetOrders();

    foreach (var item in orders)
    {
        string status = chief.GetStatuses().First(e => e.Key == item.StatusId).Value;
        Console.WriteLine($"{item.Name}\t\t {status}");
    }
}