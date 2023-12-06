namespace NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program that reads a whole number n
            // entered by the user and prints a pyramid of numbers.
            // Input: 7
            // Output: 
            // 1
            // 2 3
            // 4 5 6
            // 7

            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++) 
            {
                for (int cols = 1; cols <= rows; cols++) 
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}