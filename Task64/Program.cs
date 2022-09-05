// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int m = 9;
int n = 17;

void PrintNumbersFromTo(int m, int n)
{
    if(n < m) Console.WriteLine($"Вывод: ");
    else
    {
        {
            PrintNumbersFromTo(m, n - 1);
            Console.Write($"{n} ");
        }
    }
}

PrintNumbersFromTo(m, n);
