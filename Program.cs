// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк = ");
// var rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов = ");
// var colomns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, colomns];


// void FillingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 100);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void RegulateArray()
// {
//     int MaxArray = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int s = 0; s < array.GetLength(1) - 1; s++)
//             {
//                 if (array[i, s] < array[i, s + 1])
//                 {
//                     MaxArray = array[i, s + 1];
//                     array[i, s + 1] = array[i, s];
//                     array[i, s] = MaxArray;
//                 }
//             }
//         }
//     }
// }

// FillingArray();
// PrintArray();
// RegulateArray();
// Console.WriteLine("");
// PrintArray();

// __________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк = ");
// var rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов = ");
// var colomns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, colomns];

// void FillingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// int MinLineArray()
// {
//     int line = 0;
//     int min = int.MaxValue;
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i, j];
//         }
//         if (result < min)
//         {
//             min = result;
//             line = i;
//         }
//         Console.WriteLine($"Сумма чисел = {result} в строке {i}");
//         result -= result;
//     }
//     Console.WriteLine("");
//     Console.WriteLine($"Минимальное значение = {min}");
//     Console.WriteLine("");
//     Console.WriteLine($"Строка с минимальным значением = {line+1}");
//     return result;
// }

// FillingArray();
// PrintArray();
// Console.WriteLine("");
// MinLineArray();
// Console.WriteLine("");

// ____________________________________________________________________________________________________________

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите количество строк = ");
// var rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов = ");
// var colomns = Convert.ToInt32(Console.ReadLine());


// int[,] array1 = new int[rows, colomns];
// int[,] array2 = new int[rows, colomns];
// int[,] result = new int[rows, colomns];

// FillingArray(array1);
// PrintArray(array1);
// Console.WriteLine();
// FillingArray(array2);
// PrintArray(array2);
// Console.WriteLine();
// SumArray(result);
// PrintArray(result);

// void FillingArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] result)
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write($"{result[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void SumArray(int[,] result)
// {

//     if (array1.GetLength(0) != array2.GetLength(1))
//     {
//         Console.WriteLine("Количество строк и сторон разное!!!");
//         return;
//     }
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             result[i, j] = 0;
//             for (int s = 0; s < array1.GetLength(1); s++)
//             {
//                 result[i, j] += array1[i, s] * array2[s, j];
//             }
//         }
//     }
// }

// ______________________________________________________________________________________________________________

// Задача 60.
// Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет 
// построчно выводить массив, добавляя 
// индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] numbers = new int[2, 2, 2];

// void GenerateRandomArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 array[i, j, k] = new Random().Next(1, 10);
//             }
//         }
//     }
// }

// void PrintRandomArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ( { i }, { j }, { k } )");
//             }
//         }
//         Console.WriteLine("");
//     }
// }

// GenerateRandomArray(numbers);
// PrintRandomArray(numbers);

// _____________________________________________________________________________________________________________

// Задача 62. Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// Например, на выходе получается 
// вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// ________________________________________________________________________________________________________________________

