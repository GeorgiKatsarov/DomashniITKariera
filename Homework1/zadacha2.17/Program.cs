using System.Linq;

int[] arrToSort = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Array.Sort(arrToSort);

Console.WriteLine(String.Join(" <= ", arrToSort));