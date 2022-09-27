// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// 
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 
// 34(1,0,0) 41(1,1,0)
// 
// 27(0,0,1) 90(0,1,1)
// 
// 26(1,0,1) 55(1,1,1)

using MyClassLibrary;

int lenX = 2, lenY = 2, lenZ = 2;
double minNum = 10, maxNum = 100;

int[,,] arrayNumbers = ArrayMy.Array3dIntegerRandomNoRepeat(lenX, lenY, lenZ, minNum, maxNum);

for (int i = 0; i < lenX; i++)
{
    for (int j = 0; j < lenY; j++)
    {
        for (int k = 0; k < lenZ; k++)
        {
            Console.Write($"{arrayNumbers[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine("\n");
    }
}