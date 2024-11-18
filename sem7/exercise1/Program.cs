// Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8

void PrintNaturalNumbersToMax(int num1, int num2)
{
    if (num1 > num2) return;
    Console.Write(num1);
    if (num1 < num2) Console.Write(", ");
    PrintNaturalNumbersToMax(num1 + 1, num2);
}

void PrintNaturalNumbersToMin(int num1, int num2)
{
    if (num1 < num2) return;
    Console.Write(num1);
    if (num1 > num2) Console.Write(", ");
    PrintNaturalNumbersToMin(num1 - 1, num2);
}

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("Ошибка! Введите два разных числа");
}

PrintNaturalNumbersToMax(number1, number2);
PrintNaturalNumbersToMin(number1, number2);
