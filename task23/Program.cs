// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("ввидите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.WriteLine($"Таблица кубов чисел от 1 до {number}");
while (count <= number )
{
    int cube = count * count* count;
    Console.WriteLine($"|{count,4}  | {cube,6} |");
    count++; 
}
