class Program
{
    static void Main()
    {
        double a, b, c, product;

        Console.Write("Enter the first real number: ");
        if (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
            return;
        }

        Console.Write("Enter the second real number: ");
        if (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
            return;
        }

        Console.Write("Enter the third real number: ");
        if (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid input. Please enter a valid real number.");
            return;
        }
        product = 0;

        {
            product += 1;
        }

        if (b < 0)
        {
            product += 1;
        }

        if (c < 0)
        {
            product += 1;
        }

        if (product == 1 || product == 3)
        {
            Console.WriteLine("The product is negative.");
        }
        else
        {
            Console.WriteLine("The product is positive.");
        }
    }
}
