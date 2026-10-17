//int[] mas1 = new int[5];
//int[] mas2 = { 1, 4, 2, 9, 3 };
//int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas2[3]);

//ввод вручную
//int[] mas4 = new int[5];
//for (int i = 0; i < mas4.Length; i++)
//    mas4[i] = int.Parse(Console.ReadLine());
//for(int i = 0;i < mas4.Length; i++)
//    Console.WriteLine($"{mas4[i]}");
//ввод по формуле
//int[] mas5 = new int[5];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = 2 * i + 1;
//    Console.WriteLine($"{mas5[i]}");
//}
//Console.WriteLine();
//использование генератора случайных чисел
//Random rnd = new Random();
//int[] mas6 = new int[rnd.Next(5,15)];
//for (int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] = rnd.Next(1,100);
//    Console.Write($"{mas6[i]} ");
//}

using System.Linq.Expressions;
using System.Security.Cryptography;

//try
//{

//int[] mas = new int[10];
//Random rnd=new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next(-7, 8);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//Console.Write("Введите n:");
//int n =int.Parse(Console.ReadLine());
//    int index = -1;
//    int less_n = 0;
//    for (int i = 0;i <mas.Length;i++)
//    {
//        if (mas[i] == n) index = i;
//        if (mas[i] < n) less_n++;
//    }
//    Console.WriteLine($"Индекс последнего вхождения {n}={index}");
//    Console.WriteLine($"Количество элементов меньших {n}={less_n}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    Random rnd=new Random();
//    int[] mas = new int[n];
//    for(int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-10, 11);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    int max = mas[0];
//    for (int i = 1; i <mas.Length; i++)
//    {
//        if (mas[i] > max) max = mas[i];
//    }
//    Console.WriteLine($"max={max}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//отсортировать элементы массива по возрастанию
//Random rnd=new Random();
//int[] mas = new int[rnd.Next(10, 20)];
//for(int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next(10,100);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//for (int i = 0;i < mas.Length-1; i++)
//{
//    for (int j=i+1;j<mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//foreach (int i in mas) Console.Write($"{i} ");
//Console.WriteLine();

//try
//{
//    Console.Write("Введите размер массива:");
//    int n=int.Parse(Console.ReadLine());
//    int[] mas=new int[n];
//    Random rnd=new Random();
//    int s = 0;
//    for(int i=0; i<mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-13, 12);
//        Console.Write($"{mas[i]} ");
//        s += mas[i];
//    }
//    Console.Write($"s={s}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите размер массива:");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int s = 0;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-19, 27);
//        Console.Write($"{mas[i]} ");
//        s += mas[i];
//    }
//    Console.Write($"s={s}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

