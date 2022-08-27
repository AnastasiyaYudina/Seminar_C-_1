
// // Напишите программу, которая принимает на вход пятизначное число и
// //  проверяет, является ли оно палиндромом.

// // 14212 -> нет

// // 12821 -> да

// // 23432 -> да
// Console.Clear();
// Console.WriteLine("Введите пятизначное число:");
// int num = int.Parse (Console.ReadLine()?? "");
// if (num>99999 || num <10000)
// {
//     Console.WriteLine("Вы ввели не пятизначное число, исправьте число"); return;
// }
// else if (num<99999 && num>10000)
// {
//  if(num/10000!=num%10)
// {
//     Console.WriteLine($"Число {num} не является полиндромом");
// }
// else if (num/1000%10!=num/10%10)
// {
//     Console.WriteLine($"Число {num} не является полиндромом");
// }
// else 
// {
//     Console.WriteLine($"Число {num}  является полиндромом");
// }
// }
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты двух точек");

// Console.WriteLine("Значение X1:");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение Y1:");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение Z1:");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Значение X2:");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение Y2:");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Значение Z2:");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Точка 1 ({x1},{y1},{z1}); Точка 2({x2},{y2},{z2})");

// double result;

// Console.WriteLine ("Расстояние между точками в 3d пространстве равно");
// Console.WriteLine (result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)));


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// Console.Clear();
// Console.WriteLine ("Введите число N");
// int N = Convert.ToInt32 (Console.ReadLine()??"");
// int count = 1;

// if (N>0)

// {
// while (count <=N)
// {
//     Console.WriteLine(Math.Pow (count,3)+ ",");
//     count++;
// }
// }

// else 
// {
// while (count>=N)
// {
//     Console.WriteLine(Math.Pow (count,3)+ ",");
//     count=count-1;
// }
// }
