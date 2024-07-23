// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

class Program
{
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0) return;

        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1);
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        if (args.Length > 0)
        {
            array = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                if (int.TryParse(args[i], out int result))
                {
                    array[i] = result;
                }
                else
                {
                    Console.WriteLine($"Error parsing element {args[i]} to an integer.");
                    return;
                }
            }
        }

        PrintArrayReverse(array, array.Length - 1);
    }
}

