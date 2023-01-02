/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = new double[5];
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(0, 10000)) / 100;
        Console.Write($"{array[i]}  ");
        
        if (array[i] < min)
        {
            min = array[i];
        }
    
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    
    Console.WriteLine();
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"diff = {max-min}");