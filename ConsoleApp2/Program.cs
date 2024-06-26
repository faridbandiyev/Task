MyList myList = new MyList();

myList.Add(1);
myList.Add(2);
myList.Add(3);

Console.WriteLine("MyListdeki elementler:");

foreach (int item in myList)
{
    Console.WriteLine(item);
}

Console.WriteLine($"2 daxildirmi?: {myList.Contains(2)}");
Console.WriteLine($"2-nin indexi: {myList.IndexOf(2)}");

myList.Remove(2);
Console.WriteLine("2-ni silenden sonra:");
foreach (int item in myList)
{
    Console.WriteLine(item);
}

myList.Reverse();
Console.WriteLine("Reverse-den sonra:");
foreach (int item in myList)
{
    Console.WriteLine(item);
}