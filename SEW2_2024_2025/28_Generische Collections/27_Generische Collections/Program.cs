
List<int> myList = new List<int>();

Random random = new Random();
myList.Add(random.Next());
myList.Add(100);
myList.Add(20);

Console.WriteLine($"Elemente in Liste: {myList.Count}");
Console.WriteLine($"Summe der Elemente: {myList.Sum()}");
Console.WriteLine($"Zweites Element: {myList[1]}");

foreach( int i in myList )
{
    Console.WriteLine(i);
}