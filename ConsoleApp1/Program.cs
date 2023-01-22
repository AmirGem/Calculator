namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result;

            int firstNumber = GetNumber();

            string op = GetOperator();

            int secondNumber = GetNumber();

            MathOperation mathOperation = new(firstNumber, secondNumber);

            switch (op)
            {
                case "+":
                    result = mathOperation.Sum();
                    Console.WriteLine(result);
                    break;

                case "-":
                    result = mathOperation.Minus();
                    Console.WriteLine(result);
                    break;

                case "*":
                    result = mathOperation.Multiply();
                    Console.WriteLine(result);
                    break;

                case "/":
                    result = mathOperation.Division();
                    Console.WriteLine(result);
                    break;
            }

        }

        private static string GetOperator()
        {
            return Console.ReadLine();
        }

        private static int GetNumber()
        {
            return int.Parse(Console.ReadLine());
        }
    }


}