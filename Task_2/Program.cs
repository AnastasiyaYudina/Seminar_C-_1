// Семинар 7



// Сгенерировать двумерный массив со случайными числами, вывести его на экран,
// оформить в виде функции


// int Prompt (string mesage)
// {
//     System.Console.Write(mesage); //Ввести сообщение 
//     int result = Convert.ToInt32(Console.ReadLine());// Считывает значение
//     return result;//Возвращает результат
// }

// int[,] FillArray (int numLine, int numColums, int maxRand =20, int minRand =0)
// {
//     int[,] matrix = new int[numLine, numColums];
//     for (int i=0; i<matrix.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<matrix.GetLength(1); j++) //Столбец
//         {
//          matrix[i,j] = new Random().Next(minRand,maxRand); //[0;20] по умолчанию
//         }
//     }
//     return matrix;
// }

// void PrintArray (int [,] matrix) // Функция печати массива

// {
//     for (int i=0; i<matrix.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<matrix.GetLength(1); j++) //Столбец
//              Console.Write($"{matrix [i,j]}");
//         }
//         Console.WriteLine();
// }


// int numLine = Prompt("Введите количество строк масива");
// int numColums=Prompt("Введите количество столбцов массива");
// int maxRand = Prompt("Введите верхнюю границу диапазона");
// int minRand = Prompt("Введите нижнюю границу диапазона");
// int [,] matrix = FillArray(numLine, numColums, maxRand, minRand);
// PrintArray(matrix);




// Задача. Задайте двумерный массив размерра m на n, каждый элемент в массиве 
// находится по формуле A=m+n. Выедите полученный массив на экран. 

// int Prompt(string mesage)
// {
//     System.Console.Write(mesage); //Ввести сообщение 
//     int result = Convert.ToInt32(Console.ReadLine());// Считывает значение
//     return result;//Возвращает результат
// }

// int[,] FillArray(int numLine, int numColums) //Заполнение двумерного массива случайными числами 
// {
//     int[,] matrix = new int[numLine, numColums];
//     for (int i=0; i<matrix.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<matrix.GetLength(1); j++) //Столбец
//         {
//          matrix[i,j] = i+j; //[0;20] по умолчанию
//         }
//     }
//     return matrix;
// }

// void PrintArray (int [,] matrix) // Функция печати массива
// {
//     for (int i=0; i<matrix.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<matrix.GetLength(1); j++) //Столбец
//              Console.Write($"{matrix [i,j]}");
//     }
//         Console.WriteLine();
// }


// int [,] array = FillArray(Prompt("Введите число строк: "), Prompt("ВВедите число столбцов: "));
// PrintArray(array);



//Задание. Задайте двумерный массив. 
// Найдите элементы, у котрых обе позиции четные,
// и замените эти элемнты на их квадраты.


// int[,] FillArray(int numLine, int numColums) //Создание и заполнение двумерного массива случайными числами 
// {
//     int[,] matrix = new int[numLine, numColums]; // Создание нового массива
//     for (int i=0; i<matrix.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<matrix.GetLength(1); j++) //Столбец
//         {
//          matrix[i,j] = i+j; //[0;20] по умолчанию Формула для заполнения массива
//         }
//     }
//     return matrix; // Возвращаем результат 
// }

// void PrintArray (int [,] matrix) // Функция печати массива
// {
//     for (int i=0; i<matrix.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<matrix.GetLength(1); j++) //Столбец
//              Console.Write($"{matrix [i,j]}\t");// Вывод значений очередной строки
//     }
//         Console.WriteLine(); // Переход на следующую строку
// }

// int[,] ConvertToSql(int [,] array) //Поиск четного числа и умножение его самого на себя 
// {

//     for (int i=0; i<array.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<array.GetLength(1); j++) //Столбец
//         {
//          if (i%2==0 && j%2==0) //Условия выполнения задания
//          {
//             array [i,j] = array [i,j]*array [i,j];
//          }
         
//         }
//     }
//     return array;
// }

// int [,] massiv = FillArray (5,5); // Создаем двумерный массив, который 
// // заполняется через ф-ю FillArray, и содержит 5 строк и 5 столбцов
// PrintArray (massiv);
// System.Console.WriteLine();
// int [,] newMassiv = ConvertToSql (massiv);
// PrintArray (newMassiv);


// Задача. Задайте двухмерный массив, найдите сумму элементов по главной диагонали.

// Random rand = new Random ();
//  void FillMatrix (int [,] matr)
//  {
//     for (int i=0; i<matr.GetLength(0); i++)
//     {
//         for (int j=0; j<matr.GetLength(1); j++)
//         {
//             matr [i,j]= rand.Next (1,15);
//         }
//     }
//  }


// void PrintArray (int [,] matrix) // Функция печати массива
// {
//     for (int i=0; i<matrix.GetLength(0); i++) //Строка
//     {
//         for (int j=0; j<matrix.GetLength(1); j++) //Столбец
//              {
//              Console.Write($"{matrix [i,j]}\t");// Вывод значений очередной строки
//              }
//         System.Console.WriteLine(); // Переход на следующую строку
// }
// }
//  int [,] matrix = new int [3,3];
//  FillMatrix (matrix);
// PrintArray(matrix);
// System.Console.WriteLine(GetSum(matrix));
// int GetSum (int [,] matrix)
// {
//     int sum =0;

//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//             sum +=matrix[i,j];
//     }
//     return sum;
// }





//Задача. Задайте двумерный массив. Задайте элемент и надите первое его вхождениебь
// введите позиции по горизонтали и по вертикали
// или напишите что такого элемента нет.

Random rand = new Random ();
 void FillMatrix (int [,] matr)
 {
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            matr [i,j]= rand.Next (1,15);
        }
    }
 }


void PrintArray (int [,] matrix) // Функция печати массива
{
    for (int i=0; i<matrix.GetLength(0); i++) //Строка
    {
        for (int j=0; j<matrix.GetLength(1); j++) //Столбец
             {
             Console.Write($"{matrix [i,j]}\t");// Вывод значений очередной строки
             }
        System.Console.WriteLine(); // Переход на следующую строку
}
}

System.Console.WriteLine("Введите элемент: ");
int element = int.Parse (Console.ReadLine()?? "0");
int [,] matrix = new int [3,3];
FillMatrix (matrix);
PrintArray(matrix);
FindNumber (matrix, element);
void FindNumber (int [,] matrix, int element)
{
    
    for (int i=0; i<matrix.GetLength(0); i++)
    {
         for  (int j=0; i<matrix.GetLength(0); j++)
         {
            if (element == matrix[i,j])
            {
                System.Console.WriteLine($"Позиция элемента [{i},{j}]");
                return;
            }
         }
    }
    System.Console.WriteLine("Такого элемента нет");
    
}