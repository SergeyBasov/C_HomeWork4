/* Задача 25: Напишите цикл, который принимает на вход два
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double GetNum(string text)
{
    Console.Write(text);
    double num = double.Parse(Console.ReadLine());
    return num;
}
double numA = GetNum("Введите число A: ");
double numB = GetNum("Введите число B: ");

double result = Math.Pow(numA, numB);
Console.WriteLine($" -> {result} ({numA} в степени {numB})");