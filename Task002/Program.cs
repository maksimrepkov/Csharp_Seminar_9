// Задача № 66.
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void FindSumNumbers(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write(summ);
        return;
    }
    FindSumNumbers(m, n - 1, summ);
}

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

Console.Write("M = " + (m) + "; " + "N = " + (n) + " -> ");
FindSumNumbers(m, n, temp = 0);