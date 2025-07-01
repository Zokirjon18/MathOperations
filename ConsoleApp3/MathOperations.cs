namespace ConsoleApp3
{
    internal class MathOperations
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2) 
        {
            return num1 - num2; 
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public bool isEven(int num1)
        {
            if(num1 % 2 != 0)
            {
                return false;
            }
            return true;
        }

    }
}
