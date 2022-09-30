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

/// TODO:
/// Поставить таблицу, а внутри числа.

string IsNumber20(int number)
{
    switch (number % 20)
    {
        case 1:
            return "ый";
        case 2:
            return "ой";
        case 3:
            return "ий";
        case 4:
            return "ый";
        case 5:
            return "ый";
        case 6:
            return "ой";
        case 7:
            return "ой";
        case 8:
            return "ой";
        case 9:
            return "ый";
        case 10:
            return "ый";
        case 11:
            return "ый";
        case 12:
            return "ый";
        case 13:
            return "ый";
        case 14:
            return "ый";
        case 15:
            return "ый";
        case 16:
            return "ый";
        case 17:
            return "ый";
        case 18:
            return "ый";
        case 19:
            return "ый";
        case 20:
            return "ый";
        default:
            return "ой";
    }
}



int lenX = 8, lenY = 8, lenZ = 8;
double minNum = 0, maxNum = 1000;

int[,,] arrayNumbers = ArrayMy.Array3dIntegerRandomNoRepeat(lenZ, lenY, lenX, minNum, maxNum);

for (int i = 0; i < lenZ; i++)
{
    Console.WriteLine("\n\n");
    Console.WriteLine($"\n{i+1}-{IsNumber20(i+1)} слой.");
    for (int j = 0; j < lenY; j++)
    {
        for (int k = 0; k < lenX; k++)
        {
            string value = Convert.ToString(arrayNumbers[i, j, k]);
            for (int v = value.Length; v < Convert.ToString(maxNum).Length; v++)
            {
                value = "0" + value;
            }

            string valueI = Convert.ToString(i);
            for (int vi = valueI.Length; vi < Convert.ToString(lenZ).Length; vi++)
            {
                valueI = "0" + valueI;
            }

            string valueJ = Convert.ToString(j);
            for (int vj = valueJ.Length; vj < Convert.ToString(lenY).Length; vj++)
            {
                valueJ = "0" + valueJ;
            }

            string valueK = Convert.ToString(k);
            for (int vk = valueK.Length; vk < Convert.ToString(lenX).Length; vk++)
            {
                valueK = "0" + valueK;
            }


            Console.Write($"{value}({valueK},{valueJ},{valueI})    ");
        }
        Console.WriteLine("\n\n\n");
    }
    
}

            
