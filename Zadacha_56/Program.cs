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


using MyClassLibrary;

int rowArrayCount = 4, collumArrayCount = 4;

double[,] arrayNumbers = ArrayMy.Create2DArray(rowArrayCount, collumArrayCount);
arrayNumbers = ArrayMy.Fill2DArrayToNumbers(arrayNumbers, 0, 10, 0);

double[] sumRow = ArrayMy.AverageSumInEachRowIn2DArray(arrayNumbers);

double minSumNumbers = sumRow[0];
int indexMinSumNumbers = 0;
string sumMinAllIndex = String.Empty;
for (int i = 0; i < sumRow.Length; i++)
{
    if (minSumNumbers == sumRow[i])
    {
        sumMinAllIndex += String.Format("{0}, ",i);
    }

    if (minSumNumbers > sumRow[i])
    {
        sumMinAllIndex = String.Format("{0}, ",i);
        minSumNumbers = sumRow[i];
        indexMinSumNumbers = i;
    }
}

ArrayMy.WriteArray2D(arrayNumbers);

// ArrayMy.WriteArray(sumRow);



Console.WriteLine($"Строка(и) на позиции(ях) {sumMinAllIndex}с наименьшей(шими) суммой(мами).");