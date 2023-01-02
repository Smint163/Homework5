/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] array = new int[4];
int summ = 0;

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(-100, 100);

            if ((i % 2) == 0);
            else 
                {
                summ = summ + arr[i];
                }

            Console.Write($"{arr[i]} ");
        }
}

FillArray(array);

Console.Write($"-> {summ}");