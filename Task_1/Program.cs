// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// СЕМИНАР 1


// // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя )
// Console.Clear ();
// Console.WriteLine ("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = Convert.ToInt32(Math.Pow(number,2));
// Console.WriteLine("Решение:" + result);

// Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Clear ();
// Console.WriteLine ("Введите число 1:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число 2:");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1==number2*number2)
// Console.WriteLine ("Первое число квадрат второго");
// else 
// Console.WriteLine ("Первое число не является квадратом второго");


// Запишите программу, котррая будет выдава 
// название дня недели по заданному номеру
// Console.Clear();
// Console.WriteLine("Введите число");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7)
// {
//     Console.WriteLine("Не верное число");
// }
// else
// {
//     if (day == 1)
//     {
//         Console.WriteLine("Понедельник");
//     }
//     if (day == 2)
//     {
//         Console.WriteLine("Вторник");

//     }
//     if (day == 3)
//     {
//         Console.WriteLine("Среда");
//     }
// }




// // 4 Напишите программу, которая на вход принимает одно число (N), 
// //а на выходе показывает все целые числа в промежутке от -N до N.

// // выводим текст с запросом в терминал
// // Console.Write("Введите число: ");
// // присваиваем переменной N введенное число
// // int N = Convert.ToInt32(Console.ReadLine());
// // обяъвляем новую переменную, в которую сохраняем значение N с противоположным знаком
// // int B = -N;

// // условный цикл, который будет "работать" до тех пор, пока значение переменной B меньше либо равно значению N
// // while (B <= N)
// // {
// //     // выводим на экран значение B и пробел
// //     Console.Write(B+ " ");
// //     // увеличиваем значение B на единицу
// //     B++; // B = B + 1 аналогично B += 1 
// // }

// // 5
// // Console.Write("Введите трехзначное число: ");
// // int num = Convert.ToInt32(Console.ReadLine());
// // if (num > 99 && num <= 999){
// //     int x = num % 10;
// //     Console.WriteLine(x);
// // }
// // else{
// //     Console.WriteLine("Введенное число не трехзначное");
// // }
// // или 
// // Console.WriteLine("enter the number");
// // // int num = Convert.ToInt32(Console.ReadLine());
// // // Console.Write("result " + Math.Abs(num) % 10);


// // Напишите программу, которая выводитт случайное число 
// // из отрезка (10,99) и показывае наибольшую цифру числа 

// // 


// // Напишите программу, которая выводит случайное трехзначное числои удаляет 



// Напишите программу, которая будет принимать 
// на вход два числа и выводить, 
//является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.


// Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.


// Напишите программу, которая принимает 
// на вход два числа и проверяет, 
//является ли одно число квадратом другого.


// Напишите программу, которая принимает 
//на вход число и проверяет, кратно ли 
// оно одновременно 7 и 23.

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine ());
// if (number%7 == 0 && number%23 ==0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }

// 16. Напишите программу, которая принимает 
//на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// Console.WriteLine("Введите число 1:");
// int number1 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("Введите число 2:");
// int number2 = Convert.ToInt32(Console.ReadLine ());
//  if (number1 == number2*number2 || number2 == number1*number1 )
// {
//     Console.WriteLine("Является квадратом");
// }
// else 
// {
//     Console.WriteLine("Не является квадратом");
// }

// Напишите программу, которая будет 
// принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно 
// числу 1, то программа выводит остаток от деление

// Console.WriteLine("Введите число 1:");
// int number1 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("Введите число 2:");
// int number2 = Convert.ToInt32(Console.ReadLine ());

//  if ( number2%number1==0 )
// {
//     Console.WriteLine("Кратно");
// }
// if else (number2 !=0)
// {
//     Console.WriteLine("На ноль делить нельзя");
// }
// else 
// {
//     Console.WriteLine($"Остаток от деления {number2%number1}");
// }

// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа

// int num = new Random().Next(10, 100);
// Console.WriteLine(num);
// if (num / 10 > num % 10)
// {
//     Console.Write(num / 10);
// }
// else 
// {
//     Console.Write(num % 10);
// }



// Задание 17. Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine ("Введите координаты x");
// int x=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты y");
// int y=Convert.ToInt32(Console.ReadLine());
// if (x>0 && y>0)
// {
//     Console.WriteLine ("Первая четверть");
// }
// else if (x<0 && y>0)
// {
//     Console.WriteLine ("Вторая четверть");
// }
// else if (x<0 && y<0)
// {
//     Console.WriteLine ("Третья четверть");
// }
// else if (x>0 && y<0)
// {
//     Console.WriteLine ("Четвертая четверть");
// }
// else
// {
//     Console.WriteLine ("Определить четверть не возможно");
// }




// Console.Write("Введите координаты точки X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты точки Y: ");
// int y = int.Parse(Console.ReadLine()!);
// string mes = "";
// if (x == 0) 
// Console.Write("введите отличное от 0");
// if (y == 0) 
// Console.Write("введите отличное от 0");
// switch (x, y)
// {
//     case (>0, >0): mes = "1"; break;
//     case (>0, <0): mes = "4"; break;
//     case (<0, >0): mes = "2"; break;
//     case (<0, <0): mes = "3"; break;
// }
// Console.WriteLine(mes);

// Console.Write("Введите координаты точки X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координаты точки Y: ");
// int y = int.Parse(Console.ReadLine()!);
// string mes = "";

// switch (x, y)
// {
//     case (>0, >0): mes = "1"; break;
//     case (>0, <0): mes = "4"; break;
//     case (<0, >0): mes = "2"; break;
//     case (<0, <0): mes = "3"; break;
//     default : mes = "введите отличное от 0"; break;
// }
// Console.WriteLine(mes);


// int printQuarter(int a, int b)
// {
//     if (a>0 && b>0)
//     {
//         return 1;
//     }
//     else if (a<0 && b>0)
//     {
//         return 2;
//     }
//     else if (a<0 && b<0)
//     {
//         return 3;
//     }
//     else if (a>0 && b<0)
//     {
//         return 4;
//     }
//     else
//     {
//         return 0;
//     }
// }


// Console.WriteLine ("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Номер четверти - {printQuarter(x, y)}");



// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int quarter=int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }

//     default:
//     {
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }




// СЕМИНАР 4



// Задача 24: Напишите программу, которая 
// принимает на вход число (А) и выдаёт 
// сумму чисел от 1 до А.


// Console.Clear();
// Console.WriteLine("Введите число А");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел от 1 до А: {Summa(number)}");

// int Summa(int num)
// {
//     int sum = 0;
//     for (int i = 0; i <= Math.Abs(num); i++)
//     {
//         sum += i;
//     }
//     return sum;
// }



// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.

// Console.Clear();
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int i=0;
// if (number ==0)
// {
//     Console.WriteLine("1");
// }
// else 
// {
//     while (number!=0)
//     {
//     number = number/10;
//     i++;
//     }
//     Console.WriteLine (i);
// }



// Альтернативный вариант решения 



// Console.Write("Введите число - ");

// double N = Convert.ToDouble(Console.ReadLine());

// double digits_num = Math.Floor(Math.Log10(N) + 1);
// Console.WriteLine ("Количество цифр во введенном числе - " + digits_num

// Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.


// Console.Clear();
// Console.WriteLine("Введите число N");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение чисел от 1 до N: {Produkt(number)}");

// int Produkt(int num)
// {
//     int pr = 1;
//     for (int i = 1; i <= Math.Abs(num); i++)
//     {
//         pr*= i;
//     }
//     return pr;
// }


// Альтернативный вариант решения 



// long fact(long num)
// {
//     if (num ==1)
//     {
//     return num;
//     }
//     else 
//     {
//         return num + fact(num-1);
//     }

// }
// Console.WriteLine ("Введите число N:");
// long number = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine( "Факториал числа N =" + fact(number));



//Напишите программу, которая выводит массив
// из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] array1 = new int[8];

// Random rnd = new Random();
// Console.Write ("Случайный массив из 8 элементов в диапазоне [0,1] - ");
// for ( int i = 0; i < 8; i++)
// {
// array1[i] = rnd.Next(0,2);
// Console.Write (array1[i] + " ");
// }



// int [] array = new int [8];
// Random rnd = new Random ();
// Console.Write ("Случайный массив из 8 элемннтов в диапазоне [0,1] -");

// for (int i=0; i<8; i++)
// {
//     array [i]=rnd.Next(0,2);
//     Console.Write(array[i]+ " ");
// } 





//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// Массив 1
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }




// СЕМИНАР 5



// Массивы




// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }


// int [] RandomArrayNew (int N, int start, int end)
// {
//       int [] RandomArray = new int [N];
//       for (int i=0; i<N; i++)
//       {
//         RandomArray[i] = new Random().Next (start, end+1);
//       }
//       return RandomArray;
// } 




// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// int [] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int [] Array = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         Console.WriteLine($"Введите {i+1} элемент массива");
//      RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return Array;
// }




// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);













// 
// Console.Clear();
// int[] array = GetRandomArray(8,0,100);
// Console.WriteLine($"[{String.Join(", ", array)}]");


// int[] GetRandomArray(int size,int minValue,int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue,maxValue);
//     }

//     return result;
// }




// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");
// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");


// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Console.Clear();

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// int[] moyarray = CreateRandomArray(8,-10,11);
// Console.WriteLine(String.Join(",",moyarray));
// for (int i = 0; i < moyarray.Length; i++)
// {
//     moyarray[i]=-moyarray[i];
// }
// Console.WriteLine(String.Join(",",moyarray));



// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число 
// в массиве



// Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения 
// которых лежат в отрезке [10,99].
// int[] GetRandomArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next();
//     }

//     return result;
// }
// Console.WriteLine("Введите количество элементов в массиве");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int number =0;
// for (int i = 0; i < size; i++)
// {
//     if GetRandomArray
// }







// Семинар 6






//Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Console.Clear();

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));
// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];

// for (int i = 0; i < size; i++)
// {
// res[i] = new Random().Next(minValue, maxValue + 1);
// }
// return res;
// }

// void ReversArray1(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int k = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = k;
// }
// }

// int[] ReversArray2(int[] inArray)
// {
// int[] result = new int[inArray.Length];
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];

// }
// return result;
// }

// //Напишите программу, которая перевернёт одномерный массив
// //(последний элемент будет на первом месте, а первый - на последнем и т.д.)

// Console.Clear();
// int []array = GetArray(10,0,10);
// Console.WriteLine (String.Join (" ", array));

// int [] reversArray = ReversArray2(array);
// Console.WriteLine (String.Join (" ", reversArray));

// ReversArray1(array);
// Console.WriteLine (String.Join (" ", array));

// int []GetArray (int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i=0; i<size; i++)
//     {
//     res [i]= new Random().Next (minValue, maxValue);
//     }
//     return res;
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Введите первое число ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число ");
// int num3 = int.Parse(Console.ReadLine()!);

// if (num1 < num2 + num3 && num2<num1+num3 && num3<num2+num1)
// {
//     Console.WriteLine ("Будет существовать");
// }
// else 
// {
//     Console.WriteLine ("Не будет существовать");
// }


// Решение через массив 

// Console.Clear();
// Console.WriteLine("Введите стороны треугольника через пробел");

// string[] st = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// if (IsTreangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// bool IsTreangle(int a, int b, int c)
// {
//     return ((a + b) > c && (a + c) > b && (b + c) > a);
// }