// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.Clear();
// Console.WriteLine ("Введите число А");
// int A = int.Parse (Console.ReadLine()?? " ");
// Console.WriteLine ("Введите число B");
// int B = int.Parse (Console.ReadLine()?? " ");

// int MathPow (int num1, int num2)
// {
// if (num2==0)
// {
//     return 1;
// }
// // int result = num1;
// for (int i =0; i<num2; i++)
// {
//   result*= num1;
// }
// return result;
// }

// Console.WriteLine ($"{A} в степени {B} = {MathPow (A,B)}");



// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.WriteLine ("Введите число");
// int num = int.Parse (Console.ReadLine()?? " ");

// int sum (int number)
// {
// int result=0;
// while (number>0)
// { 
//   result+=number%10;
//   number/=10;
// }
// return result;

// }

// Console.WriteLine ($"Сумма цифр в числе {sum(num)}");


// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Console.Clear();
// Random rand = new Random();
// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0,100);
//     Console.Write($" {string.Join(",", array[i])}  ");
// }


