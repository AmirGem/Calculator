using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathOperations
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }

        public static int Division(int firstNumber, int secondNumber) 
        {
            int result = firstNumber / secondNumber;
            return result;
        }

        public static int Minus(int firstNumber, int secondNumber) 
        {
            int result = firstNumber - secondNumber;
            return result;
            
        }

        public static int Factor(int number)
        {
            int result = 1;
            for (int i = number; i > 0; i--)
            {
                result = result * i;
            }

            return result;
        }

        public static int Raidcal(int number) 
        {
            int result = number;
            for (int i = number; i > 0; i--)
            {
                int R = i * i;
                if (R == number)
                {
                    result = i; break;
                }
            }
            return result;
        }

    }
}
