// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int DigitCount(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

bool IsPalindrom(int number, int length)
{
    int leftDigit = new int();
    int rightDigit = new int();
    bool result = true;
    for (int i = 1; i <= length / 2; i++)
    {
        // получаем крайние цифры числа number
        leftDigit = (int)(number / Math.Pow(10, length - i));
        rightDigit = number % 10;
        if (leftDigit != rightDigit)
        {
            result = false;
            break;
        }
        // обрезаем наше число слева и справа
        number = (int)((number % Math.Pow(10, length - i)) / 10);
    }
    return result;
}

int digits = 5;
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (DigitCount(number) == digits)
{
    if (IsPalindrom(number, digits) == true)
    {
        Console.WriteLine("да");
    }
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine($"Введите число из {digits} цифр");
}