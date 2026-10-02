//Вариант 2 средний
try
{
    Console.WriteLine("Введите a:");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите b:");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Введите c:");
    double c = double.Parse(Console.ReadLine());

    if ((a == b) || (b == c) || (a == c))
        Console.WriteLine("Треугольник равнобедренный");
    else
        Console.WriteLine("Треугольник не равнобедренный");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}