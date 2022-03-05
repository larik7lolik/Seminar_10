// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
//первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
//3 и 4, N = 5 -> 3 4 7 11 18
//6 и 10, N = 4 -> 6 10 16 26 
Console.Write("Введите первое число: ");
int numFirst = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = int.Parse(Console.ReadLine());
Console.Write("Сколько чисел будем складывать?: ");
int count = int.Parse(Console.ReadLine());

int Summ(int a, int b, int count)
{
    if(count == 1) return a;
    if (count == 2) return b;
    else
    {
        int summ = Summ(a, b, count - 1) + Summ(a, b, count - 2);
        return summ;
    }
}
for (int i = 1; i <= count; i++)
{
    Console.Write(Summ(numFirst, numSecond, i) + " ");
}
Console.WriteLine("\n");