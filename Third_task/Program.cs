/* Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void Cube(int n)
{
    double[] nums = new double[n];
    int i = 0;

    Console.Write($"{n} -> ");

    while (i < n)
    {
        nums[i] = Math.Pow((i + 1), 3);
        Console.Write($"{nums[i]}, ");
        i++;
    }
    Console.WriteLine();
}

Cube(3);
Cube(5);