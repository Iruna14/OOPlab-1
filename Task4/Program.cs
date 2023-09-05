class Program
{
    static void Main()
    {
       
        double a, b, c, average;

        
        Console.Write("Enter the first number:  ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        c = double.Parse(Console.ReadLine());

        average = (a + b + c) / 3.0;

        Console.WriteLine("The average of the three numbers is: " + average);

        
        Console.ReadLine();
    }
}
