/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N 
с помощью рекурсии. 
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void recursion(int n, int m)
{
    if (n > m)
    {
        return;
    }

    if (n % 2 == 0)
    {
        System.Console.Write($" {n}");
    }

    recursion(n + 1, m);
}

int n = Prompt("Enter N > ");
int m = Prompt("Enter M > ");
recursion(n, m);

System.Console.WriteLine();