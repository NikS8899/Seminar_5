// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray (int size, int minRandom, int maxRandom)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minRandom,maxRandom + 1); // [-9;9]
    }
    return result;
}

int[] array= GetArray(10, 0, 1);

Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");

int result = 0;
for (int i = 0; i < array.Length; i+=2)
{
    result+= array[i];
}

System.Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {result}");