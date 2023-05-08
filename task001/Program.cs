// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.Write("Введите число =  ");
int number = Convert.ToInt32(Console.ReadLine());
int rev = number % 100;
int ver = number / 100;
if (ver+rev==ver+rev)
{
    Console.WriteLine("yes");

}
else{
    Console.WriteLine("no");

}
