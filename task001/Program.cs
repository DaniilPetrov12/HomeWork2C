// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.Write("Введите пятизначное число =  ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number % 10;
int num2 = number % 100;
int num3 = num2 / 10;
int num4 = num1 * 10 + num3;
int num5 = number / 1000;
if (num5 == num4)
{
    Console.WriteLine("yes");

}
else{
    Console.WriteLine("no");

}
