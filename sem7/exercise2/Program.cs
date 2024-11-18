// Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine());

int result = AckermannFunction(m, n);
Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}");