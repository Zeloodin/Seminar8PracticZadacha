// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 
// 2 4 | 3 4
// 3 2 | 3 3
// 
// Результирующая матрица будет:
// 
// 18 20
// 15 18
// 

using MyClassLibrary;

int matrixArr1X = 2, matrixArr1Y = 2;
double[,] matrixArr1 = new double[matrixArr1X,matrixArr1Y];

int matrixArr2X = 2, matrixArr2Y = 2;
double[,] matrixArr2 = new double[matrixArr2X,matrixArr2Y];

double[,] matrixArrResult = new double[matrixArr2X, matrixArr2Y];

matrixArr1 = ArrayMy.Fill2DArrayToNumbers(inputArray2D: matrixArr1, fromMinNumber:-5, toMaxNumber:10);
matrixArr2 = ArrayMy.Fill2DArrayToNumbers(inputArray2D: matrixArr2, fromMinNumber:-5, toMaxNumber:10);

matrixArrResult = HighMathMy.MatrixMultiplitation(matrixArr1,matrixArr2);


Console.WriteLine("Эта матрица 1.");
ArrayMy.WriteArray2D(matrixArr1);

Console.WriteLine("Эта матрица 2.");
ArrayMy.WriteArray2D(matrixArr2);

Console.WriteLine("Результат произедений, двух матриц, 1 и 2.");
ArrayMy.WriteArray2D(matrixArrResult);