// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

//  Console.Clear();

// int[] CreateRandomArray(int size, int min, int max)
// // Метод который задает массив из случайных рандомных чисел

// {
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// array[i] = new Random().Next(min, max + 1);
// }
// return array;
// }

// void ShowArray(int[] array) // Метод который выводит массив на экран
// {

// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(10, 100, 999); // Основное решение задачи
// ShowArray(myArray);

// int result = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
// if (myArray[i]%2==0)
// result++;
// }

// Console.WriteLine($"Количество четных чисел в массиве {result}");


// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



// int[] array = new int [15];
// Random rand = new Random();
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rand.Next(100,1000);
// Console.Write($"{array[i]}, ");

// if (i% 2 != 0)
// {
// sum += array[i];
// }
// }
// Console.WriteLine();
// Console.WriteLine($" Cумма элементов, стоящих на нечётных позициях {sum}");




// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76


// Console.Clear();
// int[] FillArray(int[] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rnd.Next(min, max + 1);
// }
// return array;
// }
// int[] array = new int[8];
// FillArray(array, -10, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int min = array[0];
// int max = array[0];
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] > max)
// {
// max = array[i];
// }
// else if (array[i] < min)
// {
// min = array[i];
// }
// }
// Console.Write($"Разница между максимальным и минимальным элементом массива равна {max - min} ");