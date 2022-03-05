// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int[] a, int[] b)
{
    int size = a.Length;
    double sqr_summ = 0;
    for (int i = 0; i < size; i++)
    {
        sqr_summ += Math.Pow(a[i] - b[i], 2);
    }
    return Math.Sqrt(sqr_summ);
}

void ReadArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int dimension = 3;

Console.WriteLine($"Введите координаты двух точек в {dimension}D:");
int[] A = new int[dimension];
int[] B = new int[dimension];
ReadArray(A);
ReadArray(B);

Console.WriteLine($"Расстояние между точками = {Math.Round(Distance(A, B), 2)}");