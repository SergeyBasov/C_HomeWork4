/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 

Условие задачи и то, что должена выводить программа не совсем понятно! 
Написал 2 варианта прогаммы для решения этой задачи (как я ее понял): */

// Первый вариант решения задачи через конкретные цифры в массиве из 5 чисел,
// который выводятся на экран.
int[] arr = { 1, 2, 5, 7, 19 };
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
Console.Write("-> [");
PtintArray(arr);
Console.WriteLine("]");

// Разделение пустой строкой массивов, которые друг за другом выводятся на экран.
Console.WriteLine();

// Второй вариант решения задачи через заданный массив из 8 чисел, 
// который заполняется автоматически в произвольном порядке от 0 - 100).    
int[] GetArray(int fistNum, int lastNum)
{
    int[] emptyArray = new int[8];
    for (int j = 0; j < 8; j++)
    {
        emptyArray[j] = new Random().Next(fistNum, lastNum + 1);
    }
    return emptyArray;
}

int[] array = GetArray(0, 100);
Console.Write("-> [");
Console.Write(String.Join(", ", array));
Console.Write("]");