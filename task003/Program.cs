// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int cube = 1;
// while (cube <= num)
// {
// System.Console.WriteLine(Math.Pow(cube, 3));
// cube++;
// }
for (int c = 1; c <= num; c++)
{
System.Console.Write(Math.Pow(c, 3) + " ");
}