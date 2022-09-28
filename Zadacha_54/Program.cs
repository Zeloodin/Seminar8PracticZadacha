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

using MyClassLibrary;

int rowCount = 3, collumCount = 5;
double[,] arrayNumbers = new double[rowCount, collumCount];

arrayNumbers = ArrayMy.Fill2DArrayToNumbers(arrayNumbers, 0, 10, 0);

ArrayMy.WriteArray2D(arrayNumbers);

Console.WriteLine("\n");

for (int i = 0; i < arrayNumbers.GetLength(0); i++)
{
    bool isSort = true;
    while(isSort)
    {
        for (int begStartIndex = 1; begStartIndex < arrayNumbers.GetLength(1); begStartIndex++)
        {
            if(arrayNumbers[i, begStartIndex-1] > arrayNumbers[i, begStartIndex])
            {
                isSort = true;
                double tempValue = arrayNumbers[i, begStartIndex-1];
                arrayNumbers[i, begStartIndex-1] = arrayNumbers[i, begStartIndex];
                arrayNumbers[i, begStartIndex] = tempValue;
            }
            else
            {
                isSort = false;
            }
        }

        
    }
}

ArrayMy.WriteArray2D(arrayNumbers);