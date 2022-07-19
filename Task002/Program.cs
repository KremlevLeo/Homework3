Console.WriteLine("Enter point A coordinates");
Console.Write("X = ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Y = ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Z = ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter point B coordinates");
Console.Write("X = ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Y = ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Z = ");
double z2 = double.Parse(Console.ReadLine());

double res = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {res}");