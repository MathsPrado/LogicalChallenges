// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using ValidParentheses;

string valueInput = Convert.ToString(Console.ReadLine().Trim().ToUpper());

Dictionary<char, int> valid = new Dictionary<char, int>
    {
        { '(', 1 },
        { '[', 2 },
        { '{', 3 },
    };

Dictionary<char, int> notValid = new Dictionary<char, int>
    {
        { ')', 1 },
        { ']', 2 },
        { '}', 3 },
    };

if(valueInput.Length == 1)
    return;

var valueInputArray = valueInput.ToCharArray();

if (!valid.ContainsKey(valueInputArray[0]))
    return;

var testeValid = Validation.IsValid(valueInput);

var aaaa = Validation.Valition(valueInputArray[0], valueInputArray.Skip(1).ToList());

Console.WriteLine(aaaa);
