/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N 
с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int addition(int n, int m)
{
    if (n > m)
    {
        return 0;
    }
    
    return addition(n + 1, m) + n;
}

int n = Prompt("Enter N > ");
int m = Prompt("Enter M > ");

int summa = addition(n,m);
System.Console.WriteLine(summa);