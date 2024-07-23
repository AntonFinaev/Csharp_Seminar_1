// Задание 1 Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// код
class Program
{
    static void PrintNumbers(int M, int N)
    {
        if (M > N) return;

        Console.Write(M + " ");
        PrintNumbers(M + 1, N);
    }

    static void Main(string[] args)
    {
        int M = 1;
        int N = 10;

        PrintNumbers(M, N);
    }
}