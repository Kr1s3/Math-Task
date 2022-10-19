internal class Program
{
    private static void Main(string[] args)
    {
        double a = 0.7;
        double b = 0.05;
        double x = 0.5;


        Console.WriteLine("Входные значения:");
        Console.WriteLine($"Переменная a: {a}");
        Console.WriteLine($"Переменная b: {b}");
        Console.WriteLine($"Переменная x: {x}");



        double r = ((x * x * (x + 1)) / b) - Math.Sin(x + a) * Math.Sin(x + a);
        Console.WriteLine("");
        Console.WriteLine($"Значение первого выражения R: {r}");


        double s = Math.Sqrt((x * b) / a) + Math.Pow(Math.Cos(x + b), 3);
        Console.WriteLine("");
        Console.WriteLine($"Значение второго выражения S: {s}");
    }
}