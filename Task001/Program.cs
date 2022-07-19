bool NumCompar(int a) //Разбивает число на составные и проверяет является ли число палиндромом.
{
    int[] array = new int[4];
    array[0] = a / 10000;
    array[1] = a / 1000 % 10;
    array[2] = a % 100 / 10;
    array[3] = a % 10;
    if (array[0] == array[3] & array[1] == array[2]) return true;
    else return false;
}

Console.Write("Enter a five-digit number: ");
int number = int.Parse(Console.ReadLine());

if (NumCompar(number))
{
    Console.WriteLine($"{number} -> Yes");
}
else
{
    Console.WriteLine($"{number} -> No");
}