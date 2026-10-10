using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//вариант 10 3.3
try
{

    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());

    double s = 0;
    double fact = 1;

    for (int k = 0; k <= n; k++)
    {
        if (k > 0)
            fact *= k;

        s += Math.Cos(k * x) / fact;
    }

    Console.WriteLine($"s = {s:f4}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}