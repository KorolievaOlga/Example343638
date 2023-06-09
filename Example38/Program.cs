// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble();
    }
    return result;
}
double raz(double[] ranArray)
{
    double min = ranArray[0];
    double max = ranArray[0];
    for (int i = 1; i < ranArray.Length; i++)
    {
        if (max < ranArray[i]) max = ranArray[i];
        if (min > ranArray[i]) min = ranArray[i];
    }
    return max - min;
}
Console.Clear();
double[] array = GetArray(6, 1, 99);
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {raz(array):f2}");