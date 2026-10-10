using System;
using System.Collections.Generic;
using System.Text;

//вариант 10 базовый 3.4

Console.WriteLine("|   x   |    y    |");
Console.WriteLine("------------------");

for (double x = 0.1; x <= 2.5; x += 0.2)
{
    double y = x * x + 2 * Math.PI * Math.Cos(x);
    Console.WriteLine($"| {x:f1} | {y:f4} |");
}

Console.WriteLine("------------------");