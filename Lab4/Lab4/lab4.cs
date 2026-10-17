//string name = null;
//Console.WriteLine(name);
//int n = int.Parse(Console.ReadLine()!);
//int? val = null;
//Console.WriteLine(val);

//int? x = 5;
////int z = x + 7;
//int? w = x + 7;
//int d = x.Value + 7;

//string? text = "Sam";
//string name = text ?? "Tom";
//Console.WriteLine(name);

//int? id = null;
//int persnold = id ?? 1;
//Console.WriteLine(persnold);

//30 вариант базовый
//Random random=new Random();
//double[] mas = new double[12];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//double min = mas[0];
//int index = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i]<min)
//    {
//        min=mas[i]; index = i;
//    }
//}
//Console.WriteLine($"Сумма мин.элемента {min} и его индекса{index}:{min + index:f2}");

//30 mid
//Random random = new Random();
//double[] mas1 = new double[random.Next(10, 20)];
//double[] mas2 = new double[random.Next(10, 20)];

//for (int i = 0; i < mas1.Length; i++)
//{
//   mas1
//}


//вариант 19 базовый
Random random = new Random();
int[] mas = new int[19];

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(-20, 31);
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();
int sum = 0;
int index = -1;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] < 0)
    {
        index = i;
        break;
    }
    sum += mas[i];
}
if (index != -1)
{
    Console.WriteLine($"Сумма элементов до первого отрицательного: {sum}");
}
else
{
    Console.WriteLine("Отрицательных элементов в массиве нет.");
}
