// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray (int size, int minRandom, int maxRandom)
{
    double [] array = new double [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRandom,maxRandom + 1);
    }
    return array;
}
double[] array= GetArray(10, 1, 999);


double max = array[1];
double min = array[1];

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max) max = array[i];
    else if (array[i]<min) min = array[i];q
}

Console.WriteLine($"Результат: [ {String.Join("; ", array)} ] \nМаксимальное число: {max} \nМинимальное число: {min} \nРазницу между максимальным и минимальным элементов массива: {max - min}");

