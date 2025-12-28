using System;
namespace simple_array_sum
{
    public class Result
    {
        public int MaxDistinct(string s)
        {
            // Usamos um array de booleans de tamanho 26 (letras 'a' a 'z')
            // Esta é a forma mais performática em C# para este caso.
            bool[] seen = new bool[26];
            int count = 0;

            foreach (char c in s)
            {
                // Converte o caractere para um índice de 0 a 25
                int index = c - 'a';

                // Se ainda não vimos esse caractere, ele pode iniciar uma nova substring
                if (!seen[index])
                {
                    seen[index] = true;
                    count++;
                }

                // Se já encontramos as 26 letras possíveis, podemos parar cedo
                if (count == 26) break;
            }

            return count;
        }
    }
 }

