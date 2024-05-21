// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IDictionary<int,int> map = new Dictionary<int,int>();
map.Add(1, 2);
map.Add(2, 3);
map.Add(3, 4);
map.Add(4, 5);
map.Add(1, 6);
foreach(var item in map)
{
    Console.WriteLine(item.Key+" "+ item.Value);
}
