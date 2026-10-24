Console.WriteLine("Введите строку (массив символов):");
string input = Console.ReadLine();


char[] mas = input.ToCharArray();

int open = 0; 
int close = 0;

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] == '[')
        open++;
    else if (mas[i] == ']')
        close++;
}

Console.WriteLine("Количество открывающих скобок ");
Console.WriteLine("Количество закрывающих скобок ");

if (open == close)
    Console.WriteLine("\nЧисло открывающих и закрывающих скобок ОДИНАКОВОЕ");
else
    Console.WriteLine("\nЧисло открывающих и закрывающих скобок РАЗНОЕ");