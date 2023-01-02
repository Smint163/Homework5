/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[4];
int summ = 0;

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(100, 1000);

            if ((arr[i] % 2) == 0)
                {
                summ = summ + 1;
                }
            Console.Write($"{arr[i]} ");
        }
}

FillArray(array);

Console.Write($"-> {summ}");