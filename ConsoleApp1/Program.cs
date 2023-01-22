namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            int firstN = int.Parse(Console.ReadLine());
            string Op = Console.ReadLine();
            if (Op == "!" || Op == "@")
            {
                switch (Op)
                {
                        case "!":
                        Console.WriteLine("="); Console.WriteLine(MathOperations.Factor(firstN));
                        break;

                        case "@":
                        Console.WriteLine("="); Console.WriteLine(MathOperations.Raidcal(firstN));
                        break;
                }
            }
            else
            {
            int secondN = int.Parse(Console.ReadLine());
            Console.WriteLine("=");

            switch (Op)
                {
                case "+":
                    Console.WriteLine(MathOperations.Sum(firstN, secondN));
                    break;

                case "-":
                    Console.WriteLine(MathOperations.Minus(firstN, secondN));
                    break;

                case "*":
                    Console.WriteLine(MathOperations.Multiply(firstN, secondN));
                    break;

                case "/":
                    Console.WriteLine(MathOperations.Division(firstN, secondN));
                    break;
                }
            }
        }
    }
}