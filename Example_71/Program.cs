// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из
//букв этого алфавита. n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс
/* Console.Clear();
Console.Write("Задайте длину слов: ");
int l = int.Parse(Console.ReadLine());

string massive  = "aисв";

void Show(string massive, char[] n, int length = 0)
{
    if(length == n.Length)
    {
        Console.WriteLine(new String(n)); return;
    }
    for (int i = 0; i < massive.Length; i++)
    {
        n[length] = massive[i];
        Show(massive, n, length + 1);
    }
}
Show(massive, new char[l]);
Console.WriteLine(); */

string text = "aисв";
int num = 2;

string[] Alfavit(string ABC, int n)
{
    if (n == 0) return new string[] { " " };
    string[] mass = Alfavit(ABC, n - 1);
    string[] result = new string[ABC.Length * mass.Length];// умножение кол-во слов на размер алфавита
    int k = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        for(int j = 0; j < ABC.Length; j++);
        {
            result[k] = mass[i] + ABC[j];
            k++;
        }
    }
    return result;
}
string[] array = Alfavit(text, num);
for (int i = 0; i < array.Length; i++);
{
    Console.WriteLine(array[i]);
}
 Console.WriteLine();