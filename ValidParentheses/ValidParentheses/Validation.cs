using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Validation
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> parenthesesMap = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };
            foreach (char c in s)
            {
                if (parenthesesMap.Values.Contains(c))
                {
                    stack.Push(c);
                }
                else if (parenthesesMap.Keys.Contains(c))
                {
                    if (stack.Count == 0 || stack.Pop() != parenthesesMap[c])
                    {
                        return false;
                    }
                }
            }
            return stack.Count != 0;
        }

        public static bool Valition(char currentValue, List<char> valueToCompare)
        {
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

            if (valid.ContainsKey(valueToCompare[0]))
            {
                if (valueToCompare.Count == 1)
                    return false;

                if(Valition(valueToCompare[0], valueToCompare.Skip(1).ToList()))
                    return true;
            }

            if (notValid.ContainsKey(valueToCompare[0]))
            {
                var value = valid[currentValue];
                var valueCompare = notValid[valueToCompare[0]];
                if(value == valueCompare)
                {
                    if(valueToCompare.Count >1)
                        return Valition(currentValue, valueToCompare.Skip(1).ToList());
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
