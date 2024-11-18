// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10

void PrintArrayReverse(int[] array, int index)
{
if (index < 0) return; 
Console.Write(array[index]);
if (index > 0) Console.Write(", ");
PrintArrayReverse(array, index - 1);
}

int[] arr = { 5, 7, 10, 4, 1 };
Console.WriteLine("Массив в обратном порядке:");
PrintArrayReverse(arr, arr.Length - 1);


