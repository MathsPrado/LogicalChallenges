using MaxProfit.Util;

namespace MaxProfit;

class Program
{
    static void Main(string[] args)
    {
        DoBestTime doBest = new DoBestTime();
        int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
        doBest.GetMaxProfit(prices);
        Console.WriteLine("Hello, World!");
    }
}

