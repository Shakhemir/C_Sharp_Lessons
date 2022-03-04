// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek > 0 & dayOfWeek < 6)
{
    Console.WriteLine("нет");
}
else if (dayOfWeek >= 6 & dayOfWeek <= 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Введите правильное число");
}