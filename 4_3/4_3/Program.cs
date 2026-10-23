using System.Net.Security;

//Random rnd=new Random();
//int[,] mas = new int[rnd.Next(4,9),rnd.Next(4,9)];
//for (int i=0; i<mas.GetLength(0); i++)
//{
//    for (int j =0;j<mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.WriteLine($"{mas[i,j]} ");
//    }
//    Console.WriteLine();
//}
//int count = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    if (mas[i, 1] >= 0) count++;
//}
//Console.WriteLine($"Количество отрицательных элементов во втором столбце {count}");

//вариант 19 базовый
Random rnd = new Random();
int[,] mas = new int[7,7];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(-3, 4);
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
int[] sum = new int[7];
for (int i =0; i < mas.GetLength(0); i++)
{
    for (int j = 0;j < mas.GetLength(1);j++)
    {
       sum [i] += mas[i, j];
    }
}
int count =0;
for (int i = 1; i<7; i++)
{
    if (sum[i] > sum[count]) ;
    count = i;
}
Console.WriteLine($"Строка с наибольшей суммой: {count}");