// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.Write("Введите число =  ");
int number = Convert.ToInt32(Console.ReadLine());
int n= number, dig;

int rev = 0;
while (n >0)
{
    dig = n % 10;
    rev = rev * 10+ dig;
}
if (n == rev)
{
    Console.WriteLine("Yes");
}
else{
    Console.WriteLine("No");
}