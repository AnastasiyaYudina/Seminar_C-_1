// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// System.Console.WriteLine("Введите размер массива m*n: ");
// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());
// double [,]arr = new double [m,n];
// Random random = new Random();
// for (int i=0; i<arr.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<arr.GetLength(1); j++) //Столбец
//         {
//          arr [i,j] = random.NextDouble ()*100-90;
//          Console.Write ("{0,6:f2}",arr [i,j]);
//         }
//         Console.WriteLine();
//     }



// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Random rand = new Random();
// void FillMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1, 15);
//         }
//     }
// }


// void PrintArray(int[,] matrix) // Функция печати массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) //Строка
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //Столбец
//         {
//             Console.Write($"{matrix[i, j]}\t");// Вывод значений очередной строки
//         }
//         System.Console.WriteLine(); // Переход на следующую строку
//     }
// }

// System.Console.WriteLine("Введите позицию  1: ");
// int position1 = int.Parse(Console.ReadLine() ?? "0")-1;
// System.Console.WriteLine("Введите позицию 2: ");
// int position2 = int.Parse(Console.ReadLine() ?? "0")-1;

// int[,] matrix = new int[3, 3];
// FillMatrix(matrix);
// PrintArray(matrix);
// FindNumber(matrix, position1, position2);
// void FindNumber(int[,] matrix, int position1, int position2)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j< matrix.GetLength(0); j++)
//         {
//             if (position1 == i && position2 == j || position2 == i && position1 == j)
//             {
//                 System.Console.WriteLine($"Значение элемента {matrix[i, j]}");
//                 return;
//             }

//         }
//     }
//     System.Console.WriteLine("Такого элемента нет");

// }




// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Random rand = new Random();
// void FillMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = rand.Next(1,15);
//         }
//     }
// }


// void PrintArray(int[,] matri) 
// {
//     for (int i = 0; i < matri.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matri.GetLength(1); j++) 
//         {
//             Console.Write($"{matri[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
 
// }



// int FindNumber(int[,] matr)
// {
//     int st =0; 
//     int summ =0;
//     double mid =0;
//     while (st<matr.GetLength(1))
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     { 
//             summ += matr[i,st];
//     }
//             mid = (double)summ/matr.GetLength(0); 
//             System.Console.WriteLine($"Среднее арифметическое в стобце {st+1} равно {mid.ToString ("F1")} ");
//             st++;
//             summ =0;
//     } return summ;
// }

// int[,] matrix = new int[3,3];
// FillMatrix(matrix);
// PrintArray(matrix);
// System.Console.WriteLine();
// FindNumber(matrix);
