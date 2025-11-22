namespace simple_array_sum;
class Program
{
    static void Main(string[] args)
    {

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        // Chama a função principal
        int result = Result.simpleArraySum(ar);

        Console.WriteLine(result);
    }

}

