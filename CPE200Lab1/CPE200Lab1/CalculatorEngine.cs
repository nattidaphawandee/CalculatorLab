using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class CalculatorEngine
    {
        public object lblDisplay;

        public string calculate(string operate, string firstOperand, string secondOperand, int maxOutputSize = 8)
        {
            
            switch (operate)
            {
                case "+":
                    Double a;
                    a = Convert.ToDouble(firstOperand) + Convert.ToDouble(secondOperand);
                    lblDisplay= System.Convert.ToString(a);
                    return (Convert.ToDouble(lblDisplay)).ToString();
                case "-":
                    return (Convert.ToDouble(firstOperand) - Convert.ToDouble(secondOperand)).ToString();
                case "X":
                    return (Convert.ToDouble(firstOperand) * Convert.ToDouble(secondOperand)).ToString();
                case "√":
                    return (Math.Sqrt(Convert.ToDouble(firstOperand))).ToString();

                case "÷":
                    // Not allow devide be zero
                    return (Convert.ToDouble(firstOperand) / Convert.ToDouble(secondOperand)).ToString();
                    /*if (secondOperand != "0")
                    {
                        double result;
                        string[] parts;
                        int remainLength;

                        result = (Convert.ToDouble(firstOperand) / Convert.ToDouble(secondOperand));
                        // split between integer part and fractional part
                        parts = result.ToString().Split('.');
                        // if integer part length is already break max output, return error
                        if (parts[0].Length > maxOutputSize)//เกินmaxOutputSizeไม่ได้
                        {
                            return "E";
                        }
                        // calculate remaining space for fractional part.
                        remainLength = maxOutputSize - parts[0].Length - 4;
                        // trim the fractional part gracefully. =
                        return result.ToString("N" + (remainLength));
                    }
                    break;*/
                case "%":
                    Double percentage;
                    percentage = Convert.ToDouble(firstOperand);
                    a = percentage * 0.01 ;
                    lblDisplay = System.Convert.ToString(a);
                    return (Convert.ToDouble(lblDisplay)).ToString();
                case "1/X":
                    return (Convert.ToDouble(1) / Convert.ToDouble(secondOperand)).ToString();

            }
            return(operate);
        }
    }
}
