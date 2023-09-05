class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the position of the digit (n): ");
        int n = int.Parse(Console.ReadLine());

        int nDigit = FindNthDigit(number, n);

        if (nDigit != -1)
        {
            Console.WriteLine($"The {n}-th digit from the right is: {nDigit}");
        }
        else
        {
            Console.WriteLine($"No {n}-th digit exists in the number.");
        }
    }

    static int FindNthDigit(int number, int n)
    {
        if (n < 1)
        {
            return -1;
        }

        int divisor = (int)Math.Pow(10, n - 1);

        while (n > 1 && number > 0)
        {
            number /= 10;
            n--;
        }

        if (n == 1 && number > 0)
        {
            return number % 10;
        }

        return -1; 
    }
}
