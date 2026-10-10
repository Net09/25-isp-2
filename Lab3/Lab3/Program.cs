//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//int k3 = 0;
//int kLast = 0;
//int kOdd = 0;
//int sumGreater5 = 0;
//long multGreater7 =1;
//int k05 = 0;
//int last = n % 10;
//while (n != 0)
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if(temp == last) kLast++;
//    if (temp%2==0) kOdd++;
//    if (temp > 5) sumGreater5 += temp;
//    if (temp > 7) multGreater7 *= temp;
//    if (temp == 0 || temp == 5) k05++;
//    n /= 10;
//}
//Console.WriteLine($"Количество 3:{k3}");
//Console.WriteLine($"Последняя цифра встречается:{kLast}");
//Console.WriteLine($"Количество четных:{kOdd}");
//Console.WriteLine($"Сумма больше 5:{sumGreater5}");
//Console.WriteLine($"Произведение его цифр, больших семи:{multGreater7}");
//Console.WriteLine($"Встречаются цифры 0 и 5:{k05}");

using System.Runtime.ConstrainedExecution;

//for (int i = 1; i <= 9; i++)
//{
//    for(int j = 1; j <= 9; j++)
//    {
//        Console.Write($"{i}*{j}={i * j}");
//    }
//    Console.WriteLine();
//}
//int n = 10;
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j<=i; j++)
//    {
//        Console.Write(n+"");
//    }
//    n += 10;
//    Console.WriteLine();
//}

//вариант 10 базовый
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

long sum = 0;

for (int i = m; i <= n; i++)
{
    sum += i * i;
}

Console.WriteLine($"Сумма квадратов чисел от {m} до {n}: {sum}");
