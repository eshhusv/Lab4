using Lab4;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Price<int>[] prices = new Price<int>[4];

        for(int i = 0; i < prices.Length; i++)
        {
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Cost: ");
            double cost = double.Parse(Console.ReadLine());

            Price<int> price = new Price<int>()
            {
                Id = id,
                Name = name,
                Cost = cost
            };

            prices[i] = price;
        }
        

        foreach(var item in prices)
        {
            Console.WriteLine(item);
        }

        Array.Sort(prices);

        foreach (var item in prices)
        {
            Console.WriteLine(item);
        }

        Array.Sort(prices, new CompareByCost());

        foreach (var item in prices)
        {
            Console.WriteLine(item);
        }
    }
}