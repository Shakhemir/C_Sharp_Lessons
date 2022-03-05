Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int cube = new;

for (int i = 1; i <= N; i++)
{
    cube += i * i * i;
    Console.Write(cube);
    if (i < N)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();