// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 4 Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

// выводим текст с запросом в терминал
// Console.Write("Введите число: ");
// присваиваем переменной N введенное число
// int N = Convert.ToInt32(Console.ReadLine());
// обяъвляем новую переменную, в которую сохраняем значение N с противоположным знаком
// int B = -N;

// условный цикл, который будет "работать" до тех пор, пока значение переменной B меньше либо равно значению N
// while (B <= N)
// {
//     // выводим на экран значение B и пробел
//     Console.Write(B+ " ");
//     // увеличиваем значение B на единицу
//     B++; // B = B + 1 аналогично B += 1 
// }

// 5
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num <= 999){
//     int x = num % 10;
//     Console.WriteLine(x);
// }
// else{
//     Console.WriteLine("Введенное число не трехзначное");
// }
// или 
// Console.WriteLine("enter the number");
// // int num = Convert.ToInt32(Console.ReadLine());
// // Console.Write("result " + Math.Abs(num) % 10);


// Напишите программу, которая выводитт случайное число 
// из отрезка (10,99) и показывае наибольшую цифру числа 

int num = new Random().Next(10, 100);

// Напишите программу, которая выводит случайное трехзначное числои удаляет 



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

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine ());
if (number%7 == 0 && number%23 ==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно");
}

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
