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



int rowCount = 3, collumCount = 5;
double[,] arrayNumbers = new double[rowCount, collumCount];

arrayNumbers = ArrayMy.Fill2DArrayToNumbers(arrayNumbers, 0, 10, 0);

ArrayMy.WriteArray2D(arrayNumbers);

Console.WriteLine("\n");

double[] arrayNumbersIndexRow = ArrayMy.array2DGetRow1D(arrayNumbers, 0);

ArrayMy.WriteArray(arrayNumbersIndexRow);


while (true)
{
    bool isSort = true;
    ArrayMy.WriteArray(arrayNumbersIndexRow, " ");
    for (int indexCollum = 1; indexCollum < arrayNumbersIndexRow.GetLength(0); indexCollum++)
    {
        double firstValue = arrayNumbersIndexRow[indexCollum - 1];  // 2
        double secondValue = arrayNumbersIndexRow[indexCollum];        // 1

        if (secondValue <= firstValue)
        {
            double tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

    }
    Console.WriteLine();

    // for (int indexCollum = 1; indexCollum < arrayNumbersIndexRow.GetLength(0); indexCollum++)
    // {
    //     double selectionValue = arrayNumbersIndexRow[indexCollum] - 1;  // 2
    //     double compareValue = arrayNumbersIndexRow[indexCollum];        // 1
    //     if (compareValue >= selectionValue) {}
    //     else isSort = false;
    // }
    // if (isSort == true) break;

}

