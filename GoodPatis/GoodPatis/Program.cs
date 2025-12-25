// See https://aka.ms/new-console-template for more information
using GoodPatis;


int[] nums1 = { 1, 2, 3, 1, 1, 3 };
Console.WriteLine($"Teste 1: {GoodPairsValidation.NumIdenticalPairs(nums1)} (Esperado: 4)");

// Caso de Teste 2
int[] nums2 = { 1, 1, 1, 1 };
Console.WriteLine($"Teste 2: {GoodPairsValidation.NumIdenticalPairs(nums2)} (Esperado: 6)");

// Caso de Teste 3
int[] nums3 = { 1, 2, 3 };
Console.WriteLine($"Teste 3: {GoodPairsValidation.NumIdenticalPairs(nums3)} (Esperado: 0)");

// Aguarda o usuário pressionar uma tecla para fechar
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();
