class Program
{
    static void Main()
    {
        int n;
        bool result;

        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());

        // Check if the number is greater than 20 and odd
        result = (n > 20) && (n % 2 == 1);

        // Print the result
        Console.WriteLine("Is the number greater than 20 and odd? " + result);
    }
}
