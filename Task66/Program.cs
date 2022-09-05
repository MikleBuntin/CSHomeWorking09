// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 4;
int n = 8;

int SummFromTo(int m, int n)
{
    int summ = m;
    if(n == m) return n;
    else
    {
        return n + SummFromTo(m, n-1);
    }
}

Console.WriteLine(SummFromTo(m, n));