using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Console.Write("Введите номер дня недели");
//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        Console.WriteLine("Поднедельник");
//        break;
//        case 2: Console.WriteLine("Вторник");
//        break;
//        case 3: Console.WriteLine("Среда");
//        break;
//        case 4 : Console.WriteLine("Четверг");
//        break;
//        case 5 : Console.WriteLine("Пятница");
//        break;
//        case 6 : Console.WriteLine("Суббота");
//        break;
//        case 7 : Console.WriteLine("Воскресенье");
//        break;
//        default:
//        Console.WriteLine("Нет такого дня недели");
//        break;
//}
//try
//{
//    Console.Write("Введите номер месяца");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 12: case 1: case 2:
//            Console.WriteLine("Зима");
//            break;
//        case 3: case 4: case 5:
//            Console.WriteLine("Весна");
//            break;
//        case 6: case 7: case 8:
//            Console.WriteLine("Лето");
//            break;
//        case 9:case 10: case 11:
//            Console.WriteLine("Осень");
//            break;
//        default:
//            Console.WriteLine("Нет такого месяца");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.Write("Введите номер карты");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Введите номер масти");
//    int m = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 6: Console.WriteLine("Шестерка");
//            break;
//        case 7: Console.WriteLine("Семерка");
//            break;
//        case 8: Console.WriteLine("Восьмерка");
//            break;
//        case 9: Console.WriteLine("Девятка");
//            break;
//        case 10: Console.WriteLine("Десятка");
//            break;
//        case 11: Console.WriteLine("Валет");
//            break;
//        case 12: Console.WriteLine("Дама");
//            break;
//        case 13: Console.WriteLine("Король");
//            break;
//        case 14: Console.WriteLine("Туз");
//            break;
//        default:
//            Console.WriteLine("Нет такой карты");
//            break;
//    }
//    switch(m)
//    {
//        case 1: Console.WriteLine("Пик");
//            break;
//            case 2 : Console.WriteLine("Треф");
//            break;
//            case 3 : Console.WriteLine("Бубен");
//            break;
//            case 4 : Console.WriteLine("Червей");
//            break;
//            default : Console.WriteLine("Нет такой масти");
//            break;
//    }


//    }    
//catch (Exception e)
//    {
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.Write("Введите число");
//    double x = double .Parse(Console.ReadLine());
//    if (x % 100 >= 11 && x % 100 <= 14) Console.WriteLine($"{x} рублей");
//    else
//    {
//        switch (x % 10)
//        {
//            case 1:
//                break;
//                case 2:
//                case 3:
//                case 4:
//                Console.WriteLine($"{x}рубля");
//                break;
//            default:
//                Console.WriteLine($"{x}рубелей");
//                break;
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.Write("Введите число");
//    int x = int.Parse(Console.ReadLine());
//    switch (x)
//    {
//        case 1:
//            {
//                double R1 = 6, R2 = 10, R3 = 2;
//                double RPosl = R1 + R2 + R3;
//                Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//                double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//                Console.WriteLine($"Параллельное сосединение: {RPar:F2}");
//            }
//            break;
//        case 2:
//            {
//                double R1 = 3, R2 = 5, R3 = 7;
//                double RPosl = (R1 + R2 + R3);
//                Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//                double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//                Console.WriteLine($"Параллельное сосединение: {RPar:F2}");
//            }
//            break;
//        case 3:
//            {
//                double R1 = 4, R2 = 12, R3 = 8;
//                double RPosl = (R1 + R2 + R3);
//                Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//                double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//                Console.WriteLine($"Параллельное сосединение: {RPar:F2}");
//            }
//            break;
//        default: break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.WriteLine("Введите число:");
//    int n = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1:
//            {
//                double a = 1.5, b = 5.7, z = Match.Tan(Math.Abs(Math.Tan(b * x)));
//                double y = 0;
//                if(x<=a)
//                {
//                    y = Math.Pow(a, 3) + Math.Atan(Math.Pow(Math.Sin(b * x), 3)) + Math.Pow;
//                          (Math.Cos(x * x), 2);
//                }
//                else if (x>a&&x<Math.Log(b))
//                {

//                }
//            }
//            break;
//    }
//}



//вариант 2 базовый


//try
//{
//    Console.Write("Введите a: ");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b: ");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c: ");
//    double c = double.Parse(Console.ReadLine());
//    int k = 0;
//    if ((a >= b && a <= c) || (a <= b && a >= c)) k = 1;
//    if ((b >= a && b <= c) || (b <= a && b >= c)) k = 2;
//    if ((c >= a && c <= b) || (c <= a && c >= b)) k = 3;
//    switch (k)
//    {
//        case 1:
//            Console.WriteLine(a);
//            break;
//        case 2:
//            Console.WriteLine(b);
//            break;
//        case 3:
//            Console.WriteLine(c);
//            break;
//        default: break;
//    }

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}