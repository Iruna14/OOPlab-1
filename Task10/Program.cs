class Program
{
    static void Main()
    {
        double a, b, c;

        Console.Write("Enter the first number: ");
        if (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter the second number: ");
        if (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter the third number: ");
        if (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        double biggest;
        if (a >= b && a >= c)
        {
            biggest = a;
        }
        else if (b >= a && b >= c)
        {
            biggest = b;
        }
        else
        {
            biggest = c;
        }

        Console.WriteLine($"The biggest number is {biggest}");
    }
}