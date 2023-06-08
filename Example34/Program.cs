// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int EvenNumbersInArray(int[] array)
{   
    int sum = 0;
    foreach (int el in array)
    {
      if (el % 2 == 0) sum +=1;
    }
    return sum;
}

Console.Clear();
int[] array = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", array));
int sum = EvenNumbersInArray(array);
Console.WriteLine($"Количество четных чисел в массиве {sum}");