// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// *********************Задача 1**********************************
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Введите длинну стороны");
// int S1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длинну стороны");
// int S2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длинну стороны");
// int S3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Стороны: "+S1+","+S2+","+S3);
// if (S1+S2>S3&&S1+S3>S2&&S2+S3>S1)
// {
//     Console.WriteLine("Такой треугольник возможен");
// }
// else Console.WriteLine("Треугольник не возможен");

// ******************Конец********************************
// *****************Задача 2******************************
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string str = "";

// while (num>0)
// {
//     str = num%2 + str;
//     num/=2;
// }

// Console.WriteLine(str);

// *****************************Конец*************************
// **************************Задача 3*************************
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = 0;
// int num2 = 1;
// Console.WriteLine(num1);
// Console.WriteLine(num2);
// for (int i = 3; i <= num; i++)
// {
//     int sumnum=num1+num2;
//     Console.WriteLine(sumnum);
//     num1=num2;
//     num2=sumnum;
// }

// *********************Конец********************
// ********************Задача 4******************
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

// int [] array1 = {4335,0,21,8,-32};
// int [] array2 = new int [array1.Length];
// for (int i = 0; i < array1.Length; i++)
// {
//     array2[i]=array1[i];
// }
// Console.WriteLine("["+String.Join(",",array2)+"]");

// ****************************Конец***********************
// ***************************Задача 5*********************
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int [] array = {6,9,3,2,-5,10};

// for (int i = 0; i < array.Length/2; i++)
// {
//     int ch = array[i];
//     array[i]=array[array.Length-1-i];
//     array[array.Length-1-i]=ch;
// }
// Console.WriteLine(String.Join(",",array));
// ********************Конец***************************



