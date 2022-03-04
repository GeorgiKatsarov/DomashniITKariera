using System.Linq;
string[] products = Console.ReadLine().Split(' ').ToArray();
int[] quantity = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
bool done = false;
string element = " ";




    for (int i = 0; i < products.Length; i++)
    {
        string[] order = Console.ReadLine().Split(' ').ToArray();
        if (order[0] == "done")
            break;
        else
            element = order[0];
        int index1 = Array.IndexOf(products, element);
        decimal cena = int.Parse(order[1]) * price[index1];
        Console.WriteLine("{0} x {1} costs {2:f2}", order[0], order[1], cena);
    } 
