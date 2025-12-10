// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var lalal = "Matheus Prado de   lima";

var result = lalal
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Last().Length;


