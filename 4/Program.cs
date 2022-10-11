// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B (степень): ");
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int res = 1;

while(i < B)
{
res = res * A;
i++;
}
Console.WriteLine($"{A} в степени {B} равно {res}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int a = 0;
// while (x > 0)
// {
// a = a + x%10;
// x = x/10;
// i++;
// }
// Console.WriteLine($"Сумма цифр в числе: {a}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int [8];
// int i = 0;

// for(i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,100);
//     Console.Write($"{array[i]} ");
// }