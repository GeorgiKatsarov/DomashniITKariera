using System.Linq;


string[] products = Console.ReadLine().Split(' ');
long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

string[] command = Console.ReadLine().Split(' ');
int index = 0;

while (command[0] != "done")
{
    index = Array.IndexOf(products, command[0]);
    if(quantity.Length - 1 < index)
    {
        Console.WriteLine("We do not have enough {0}", command[0]);
    }
    else if (quantity[index] < int.Parse(command[1]))
    {
        Console.WriteLine("We do not have enough {0}", command[0]);
        ;
    }
    else
    {
        Console.WriteLine($"{command[0]} x  {command[1]} costs {int.Parse(command[1]) * price[index]}");
        quantity[index] = quantity[index] - int.Parse(command[1]);
    }
    command = Console.ReadLine().Split(' ');
}

