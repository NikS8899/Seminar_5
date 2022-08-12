// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray (int size, int minRandom, int maxRandom)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minRandom,maxRandom + 1); // [-9;9]
    }
    return result;
}

int[] array= GetArray(8, 0, 999);

Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) result++;
}

System.Console.WriteLine($"Количество чётных чисел в массиве: {result}");