namespace simple_array_sum;
class Program
{
    static void Main(string[] args)
    {

        Result sol = new Result();

        // Exemplos do Problema
        Console.WriteLine($"'abab' -> {sol.MaxDistinct("abab")}"); // Saída: 2
        Console.WriteLine($"'abcd' -> {sol.MaxDistinct("abcd")}"); // Saída: 4
        Console.WriteLine($"'aaaa' -> {sol.MaxDistinct("aaaa")}"); // Saída: 1

        // Exemplo com string longa
        string longa = "thequickbrownfoxjumpsoverthelazydog";
        Console.WriteLine($"Alfabeto completo -> {sol.MaxDistinct(longa)}"); // Saída: 26

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para fechar...");
        Console.ReadKey();
    }

}

