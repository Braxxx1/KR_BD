string[] wordSpis = Console.ReadLine().Split(" ");
int size = 0;
foreach (var item in wordSpis)
{
    if (item.Length <= 3)
    {
        size += 1;
    }    
}

string[] newWordSpis = new string[wordSpis.Length];
int index = 0;
foreach (var item in wordSpis)
{
    if (item.Length <= 3)
    {
        newWordSpis[index] = item;
        index++;
    }    
}

foreach (var item in newWordSpis)
{
    Console.WriteLine(item);
}