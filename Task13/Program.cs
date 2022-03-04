// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = Convert.ToString(number).Length;

if (size > 3)
{
    for (int i = size; i > 3; i--)
    {
        number /= 10;
    }
}
if (size >= 3)
{
    Console.WriteLine($"Третья цифра = {number % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}