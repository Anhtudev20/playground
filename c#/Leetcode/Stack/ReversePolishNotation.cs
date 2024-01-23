using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class ReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            if (tokens.Length < 2) return Convert.ToInt32(tokens[0]);
            Stack<int> rpn = new Stack<int>();
            string[] operators = new string[] {"+", "-", "*", "/"};
            int expressResult = 0;
            for(int i = 0; i < tokens.Length; i++)
            {
                if (!operators.Contains(tokens[i]))
                {
                    rpn.Push(Convert.ToInt32(tokens[i]));
                }
                else
                {
                    int numberTop2 = rpn.Pop();
                    int numberTop1 = rpn.Pop();
                    switch (tokens[i])
                    {
                        case "+":
                            expressResult = numberTop1 + numberTop2;
                            break;
                         case "-":
                            expressResult = (numberTop1 - numberTop2);
                            break;
                         case "*":
                            expressResult = numberTop1 * numberTop2;
                            break;
                         case "/":
                            expressResult = numberTop1 / numberTop2;
                            break;
                    }
                    rpn.Push(expressResult);

                }
            }

            return expressResult;
        }
    }
}
