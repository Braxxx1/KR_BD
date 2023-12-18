string wordItems = Console.ReadLine();
string[] wordSpis = wordItems.Split(" ");
foreach (var item in wordSpis)
{
    Console.WriteLine(item);
}