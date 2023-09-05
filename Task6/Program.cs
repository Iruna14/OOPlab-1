class Program
{
    static void Main()
    {
         int n, lastDigit;

        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());

        lastDigit = n % 10;


        Console.WriteLine("The last digit of " + n + " is: " + lastDigit);
    }
}





