using System.Linq;
List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<string> command = Console.ReadLine().Split(' ').ToList();
List<int> FinalList = new List<int>();
while (command[0] != "Odd" && command[0] != "Even")
{
    if (command[0] == "Delete")
    {
        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] == int.Parse(command[1]))
            {
                ints.Remove(ints[i]);
            }

        }
    }
    else if (command[0] == "Insert")
    {
       
        ints.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
    command = Console.ReadLine().Split(' ').ToList();

}
if (command[0] == "Odd")
{
    foreach (var item in ints)
    {
        if (item % 2 != 0)
        {
            FinalList.Add(item);
        }

    }
}
else
{
    foreach (var item in ints)
    {
        if (item % 2 == 0)
        {
            FinalList.Add(item);
        }

    }
}
Console.WriteLine(String.Join(" ", FinalList));