// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;

        if (args.Length >= 2 && int.TryParse(args[0], out m) && int.TryParse(args[1], out n))
        {
            Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
        }
        else
        {
            Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
        }
    }
}

