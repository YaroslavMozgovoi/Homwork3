//  Задача 19 Напишите программу. 
// 1.которая принимает на вход пятизначное число.
// 2.Проверяет, является ли оно палиндромом.
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//  14212 -> нет
//  12821 -> да
//  23432 -> да

Console.WriteLine("Введите пятизначное число");
int numbe = Convert.ToInt32(Console.ReadLine());

int palindrome = Palindrome(numbe);

if (numbe > 99999) Console.WriteLine("Введённое число не соответствует диапозону");
else if (numbe < 10000) Console.WriteLine("Введённое число не соответствует диапозону");
else if(palindrome==1)Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не палиндром"); 

int Palindrome(int n)
{
    int x1 = n / 10000;
    int x2 = (n % 10000) / 1000;
    int x4 = (n / 10) % 10;
    int x5 = n % 10;

    if (x1 == x5)
    {
        if (x2 == x4)
        {
            return 1;
        }
        return 0;
    }
    return 0;

}