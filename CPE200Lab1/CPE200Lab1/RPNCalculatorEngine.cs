using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine : CalculatorEngine
    {
        public new string Process(string str)
        {
            if (str == "" || str == null) return "E";
            Stack<string> rpnStack = new Stack<string>();
            List<string> parts = str.Split(' ').ToList<string>();
            string result;
            string firstOperand, secondOperand;
            int number = 0, operate = 0;


            foreach (string token in parts)
            {
                if (token.Length > 1)
                {
                    char num, sign;
                    sign = Convert.ToChar(token.Substring(0, 1));
                    num = Convert.ToChar(token.Substring(1, 1));
                    if (sign == '+' || sign == 'X' || sign == '÷')
                    {
                        return "E";
                    }
                    if (num == '-' || num == 'X' || num == '+' || num == '÷')
                    {
                        return "E";
                    }
                }




                if (isNumber(token))
                {
                    number++;
                    rpnStack.Push(token);
                }
                else if (isOperator(token))
                {
                    //FIXME, what if there is only one left in stack?
                    operate++;
                    try
                    {
                        secondOperand = rpnStack.Pop();
                        firstOperand = rpnStack.Pop();
                    }
                    catch { return "E"; }
                    result = calculate(token, firstOperand, secondOperand, 4);
                    if (result is "E")
                    {
                        return result;
                    }
                    rpnStack.Push(result);
                }
            }
            //FIXME, what if there is more than one, or zero, items in the stack?

            if (number - 1 != operate) return "E";

            try { result = rpnStack.Pop(); }
            catch { return "E"; }
            return result;
        }
    }
}