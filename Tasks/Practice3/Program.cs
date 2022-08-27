// Написать программу копирования массив
Console.Clear();
int[] arraycopy = new int[10];
int a = 0;
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
    Console.WriteLine();
    Console.WriteLine("Копия массива: ");
for (int i = 0; i < array.Length; i++)
{
    arraycopy[a] = array[i];
    Console.Write($"{arraycopy[a]} ");
}