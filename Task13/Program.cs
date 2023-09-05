class Program
{
    static void Main()
    {
        int n, factorial;
        factorial = 1;

        Console.Write("Enter a number to calculate its factorial: ");
        if (int.TryParse(Console.ReadLine(), out n))
        {
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else if (n == 0)
            {
                Console.WriteLine("The factorial of 0 is 1.");
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine($"The factorial of {n} is {factorial}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}