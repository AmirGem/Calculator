namespace ConsoleApp
{
    public class MathOperation
    {

        public int FirstNumber { get; init; }
        public int SecoundNumber { get; init; }

        public MathOperation(int firstNumber, int secoundNumber)
        {
            FirstNumber = firstNumber;
            SecoundNumber = secoundNumber;
        }

        public int Sum()
        {
            return FirstNumber + SecoundNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecoundNumber;
        }

        public int Division()
        {
            return FirstNumber / SecoundNumber;
        }

        public int Minus()
        {
            return FirstNumber - SecoundNumber;
        }

        public int Factorial()
        {
            int result = 1;
            for (int i = FirstNumber; i > 0; i--)
            {
                result = result * i;
            }

            return result;
        }

        public int Raidcal()
        {
            int result = FirstNumber;
            for (int i = FirstNumber; i > 0; i--)
            {
                int R = i * i;
                if (R == FirstNumber)
                {
                    result = i; break;
                }
            }
            return result;
        }

    }
}
