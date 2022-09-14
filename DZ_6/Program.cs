//Задача 41. Пользователь вводит с клавиатуры М числел.
// Посчитайте, сколько чисел больше нуля ввел пользователь. 

// Console.Clear();

// Console.WriteLine("Введите с кливиатуры M чиcел:");

// int size = int.Parse(Console.ReadLine() ?? "0");
// int [] SizeArray = new int [size];

// for (int i=0; i<size; i++)
// {
//     Console.WriteLine($"Число {i+1}: ");
//     SizeArray[i] = int.Parse(Console.ReadLine()?? "0");
// }


// void CountArray (int[]array)
// {
//     int count =0;
//     for (int i=0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//         if (array[i]>0)
//         {
//             count+=1;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Вы ввели {count} положителных числа");
// }

// CountArray(SizeArray);



// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// int Prompt (string message)
// {
//     System.Console.Write(message);
// int result = Convert.ToInt32(Console.ReadLine());
// return result;
// }

// int k1 = Prompt ("Значение k1 ");
// int b1 = Prompt ("Значение b1 ");
// int k2 = Prompt ("Значение k2 ");
// int b2 = Prompt ("Значение b2 ");

// void Check(double k1, double b1, double k2, double b2) //Функция проверки условий и поиска кординаты точки
// {
//     if (b1==b2 && k1==k2)
//     {
//         System.Console.WriteLine("Прямые совпадают");
//     }
//     else if (k1==k2)
//     {
//         System.Console.WriteLine("Прямые параллельны");
//     }
//     else
//     {   
//     double x = (b2-b1)/(k1-k2);
//     double y = k1*x +b1;
//     var result =(x,y);
//     Console.WriteLine($"Коордитнаты точки пересечения ({(result)})");
//     }
// } 

// Check(k1, b1, k2, b2);
