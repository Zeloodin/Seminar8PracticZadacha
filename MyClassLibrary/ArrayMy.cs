namespace MyClassLibrary;

public class ArrayMy
{
    /// Показывает одномерный массив.
    static public void WriteArray<T>(T[] inputArray, string spaceEnd = "\n")
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write(inputArray[i] + spaceEnd);
        }
    }

    /// Показывает двумерный массив.
    static public void WriteArray2D<T>(T[,] inputArrayND)
    {
        int rowsCount = inputArrayND.GetUpperBound(0) + 1;    // Колличество строк
        int collumsCount = inputArrayND.Length / rowsCount;        // Колличество столбцов

        for (int y = 0; y < rowsCount; y++)
        {
            for (int x = 0; x < collumsCount; x++)
            {
                Console.Write(inputArrayND[y, x] + " ");
            }
            Console.WriteLine();
        }
    }



        /// Показывает трёхмерный массив.
    static public void WriteArray3D<T>(T[,] inputArray3D)
    {
        int xCount = inputArray3D.GetUpperBound(0) + 1;         // Колличество x
        int yCount = inputArray3D.Length / xCount;              // Колличество y
        int zCount = inputArray3D.Length / xCount / yCount;     // Колличество Z

        for (int x = 0; x < xCount; x++)
        {
            for (int y = 0; y < yCount; y++)
            {
                for (int z = 0; z < zCount; z++)
                {
                    Console.Write(inputArray3D[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    /// Создаёт двумерный массив.
    static public double[,] Create2DArray(int xCountRows, int yCountCollums)
    {
        double[,] array2D = new double[xCountRows, yCountCollums];
        return array2D;
    }

    /// Создаёт трёхмерный массив.
    static public double[,,] Create3DArray(int xCount, int yCount, int zCount)
    {
        double[,,] array3D = new double[xCount, yCount, zCount];
        return array3D;
    }

  


    /// Заполняет числами в двумерный массив.
    static public double[,] Fill2DArrayToNumbers(double[,] inputArray2D, double fromMinNumber = 0.0, double toMaxNumber = 10.0, int lengthOfDigitAfterDecimalPoint = 0)
    {
        int rowsCount = inputArray2D.GetUpperBound(0) + 1;    // Колличество строк
        int collumsCount = inputArray2D.Length / rowsCount;        // Колличество столбцов

        for (int xCountRows = 0; xCountRows < rowsCount; xCountRows++)
        {
            for (int yCountCollums = 0; yCountCollums < collumsCount; yCountCollums++)
            {
                inputArray2D[xCountRows, yCountCollums] = RandomMy.RandomNextPlus(lengthOfDigitAfterDecimalPoint, fromMinNumber, toMaxNumber);
            }
        }
        return inputArray2D;
    }


    /// Заполняет числами в трёхмерный массив.
    static public double[,,] Fill3DArrayToNumbers(double[,,] inputArray3D, double fromMinNumber = 0.0, double toMaxNumber = 10.0, int lengthOfDigitAfterDecimalPoint = 0)
    {
        int xCount = inputArray3D.GetUpperBound(0) + 1;         // Колличество x
        int yCount = inputArray3D.Length / xCount;              // Колличество y
        int zCount = inputArray3D.Length / xCount / yCount;     // Колличество Z

        for (int x = 0; x < xCount; x++)
        {
            for (int y = 0; y < yCount; y++)
            {
                for (int z = 0; z < zCount; z++)
                {
                    inputArray3D[xCount, yCount, zCount] = RandomMy.RandomNextPlus(lengthOfDigitAfterDecimalPoint, fromMinNumber, toMaxNumber);
                }            
            }
        }
        return inputArray3D;
    }





    /// TODO
    // string[] SearchInDoubleNestedArray<T>(T[,] inputArray, T inputFindToElement)
    // {
    //     string foundElements = string.Empty;
    //     int rowsCount = inputArray.GetUpperBound(0) + 1;
    //     for (int rowsI = 0; rowsI < rowsCount; rowsI++)
    //     {
    //         if (inputArray[rowsI].GetType() !=)
    //         {
    //             foundElements += Array.Find(inputArray[rowsI], element => element == inputFindToElement);
    //         }
    //         else
    //         {
    //             foundElements +=$"{SearchInArray2D(inputArray[rowsI], inputFindToElement)} ";
    //         }
    //     }
    //     return (foundElements).Split(" ");
    // }



    /// TODO
    /// mode: 0. an element in the array
    /// mode: 1. shows found items
    /// mode: 2. shows found items with coordinates
    /// mode: 3. shows the element by coordinates
    /// mode: 4. 
    static public string[,] SearchInArray2D<T>(T[,] inputArray, string elementToFind = "", int mode = 0, int inputRow = 0, int inputCollum = 0)
    {
        string foundElements = string.Empty;
        int rowsCount = inputArray.GetUpperBound(0) + 1;
        int collumsCount = inputArray.Length / rowsCount;
        int numberOfFoundElements = 0;
        if (mode != 3)
        {
            for (int rowsI = 0; rowsI < rowsCount; rowsI++)
            {
                for (int collumsJ = 0; collumsJ < collumsCount; collumsJ++)
                {
                    // Compare specified and selected item
                    // Сравнить указанный и выбранный элемент 
                    // input: inputArray, rowsI, collumsJ, elementToFind, mode, numberOfFoundElements
                    foundElements += SearchInArray2DModes.CompareSpecifiedAndSelectedItem(inputArray: inputArray,
                                                                                        rows: rowsI,
                                                                                        collums: collumsJ,
                                                                                        elementToFind: elementToFind,
                                                                                        mode: mode,
                                                                                        numberOfFoundElements: ref numberOfFoundElements);

                }
            }
        }
        if (mode == 0) // Void mode: 0.
        {
            string[,] array2DStringEmpty = new string[,] {{""},{""}};
            if (numberOfFoundElements > 0)
            {
                Console.WriteLine($"Элемент для поиска: {elementToFind}, найденно колличество: {numberOfFoundElements}");
                return array2DStringEmpty;
            }
            Console.WriteLine($"Такого элемента {elementToFind} в массиве нет");
            return array2DStringEmpty;
        }

        if (mode == 3) // Void mode: 3.
        {
            try
            {
                string[,] result = new string[,] {{Convert.ToString(inputArray[inputRow, inputCollum])},{""}};
                return result;
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка. Вышли за рамки границы длины массива.");
            }
        }

        string[,] arrayList = new string[rowsCount,3];

        string[] foundElements1DArray = foundElements.Split("[_ss_[_ss_]_ss_]");

        string[] separators = new string[] { "[_ia_[_ia_]_ia_]","[_rc_[_rc_]_rc_]" };
            
        for (int i = 0; i < rowsCount; i++)
        {   
             for (int j = 0; i < 3; i++)
            {
                try
                {
                    arrayList[i,j] = (Convert.ToString(foundElements1DArray[i])).Split(separators, StringSplitOptions.RemoveEmptyEntries)[j];
                }
                catch
                {
                    arrayList[i,j] = "";
                }
            }
        }
        return arrayList;
    }






    static public  double[] Array2DSumRowsAverage<T>(T[,] inputArray2D, int lenOfNumsAftrPoint = 0)
    {
        int rowsCount = inputArray2D.GetLength(0);     // Колличество строк
        int collumsCount = inputArray2D.GetLength(1);  // Колличество столбцов
        double[] sumAverage = new double[collumsCount];
        for (int collum = 0; collum < collumsCount; collum++)
        {
            for (int row = 0; row < rowsCount; row++)
            {
                sumAverage[collum] += Convert.ToDouble(inputArray2D[row,collum]);
            }
            sumAverage[collum] = Math.Round(sumAverage[collum] / Convert.ToDouble(rowsCount),lenOfNumsAftrPoint);
        }
        return sumAverage;
    }


    static public  double[] Array2DSumCollumsAverage<T>(T[,] inputArray2D, int lenOfNumsAftrPoint = 0)
    {
        int rowsCount = inputArray2D.GetLength(0);     // Колличество строк
        int collumsCount = inputArray2D.GetLength(1);  // Колличество столбцов
        double[] sumAverage = new double[collumsCount];
        for (int row = 0; row < rowsCount; row++)
        {
            for (int collum = 0; collum < collumsCount; collum++)
            {
                sumAverage[row] += Convert.ToDouble(inputArray2D[row,collum]);
            }
            sumAverage[row] = Math.Round(sumAverage[row] / Convert.ToDouble(collumsCount),lenOfNumsAftrPoint);
        }
        return sumAverage;
    }

}
