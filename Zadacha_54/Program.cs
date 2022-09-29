// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 
// В итоге получается вот такой массив:
// 
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using System.Linq;

using MyClassLibrary;
using NoMyLibrary;



int rowCount = 4, collumCount = 4;
double[,] arrayNumbers = new double[rowCount, collumCount];

arrayNumbers = ArrayMy.Fill2DArrayToNumbers(arrayNumbers, 0, 10, 0);

ArrayMy.WriteArray2D(arrayNumbers);




// arrayNumbers = ArrayMy.Array2DSortUp(arrayNumbers);
// arrayNumbers = ArrayMy.Array2DSortDown(arrayNumbers);

Console.WriteLine("\nПо возрастанию");
ArrayMy.WriteArray2D(ArrayMy.Array2DSortUp(arrayNumbers));
Console.WriteLine("\nПо убыванию");
ArrayMy.WriteArray2D(ArrayMy.Array2DSortDown(arrayNumbers));
