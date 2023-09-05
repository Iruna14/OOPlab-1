class Program
{
    static void Main()
    {
        double a, b, h, area;

        Console.Write("Enter the value of base side a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter the value of base side b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Enter the value of the height h: ");
        h = double.Parse(Console.ReadLine());

        area = (a + b) / 2 * h;

        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}