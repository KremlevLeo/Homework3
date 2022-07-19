void Cubing(double number)
{
    double res = 1;
    double count = 0;
    while (count < number)
    {
        res = Math.Pow(res, 3);
        count++;
        Console.Write(res + " ");
        res = count;
        res++;
    }

}

Console.Write("Enter number: ");

double num = double.Parse(Console.ReadLine());
Console.Write(num + " -> ");
Cubing(num);
