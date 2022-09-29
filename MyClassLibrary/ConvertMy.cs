namespace MyClassLibrary;


public class ConvertMy
{

    public static bool TypeToBoolean<T>(T inputType)
    {
        return Convert.ToBoolean(inputType);
    }


    public static byte TypeToByte<T>(T inputType)
    {
        return Convert.ToByte(inputType);
    }


    public static char TypeToChar<T>(T inputType)
    {
        return Convert.ToChar(inputType);
    }


    public static decimal TypeToDecimal<T>(T inputType)
    {
        return Convert.ToDecimal(inputType);
    }


    public static double TypeToDouble<T>(T inputType)
    {
        return Convert.ToDouble(inputType);
    }


    public static short TypeToInt16<T>(T inputType)
    {
        return Convert.ToInt16(inputType);
    }


    public static int TypeToInt32<T>(T inputType)
    {
        return Convert.ToInt32(inputType);
    }


    public static long TypeToInt64<T>(T inputType)
    {
        return Convert.ToInt64(inputType);
    }


    public static sbyte TypeToSByte<T>(T inputType)
    {
        return Convert.ToSByte(inputType);
    }

    public static string TypeToString<T>(T inputType)
    {
        return Convert.ToString(inputType)!;
    }


    public static ushort TypeToUInt16<T>(T inputType)
    {
        return Convert.ToUInt16(inputType);
    }


    public static uint TypeToUInt32<T>(T inputType)
    {
        return Convert.ToUInt32(inputType);
    }


    public static ulong TypeToUInt64<T>(T inputType)
    {
        return Convert.ToUInt64(inputType);
    }


    static public double[] ConvertArray1DToDouble<T>(T[] inputArray1D)
    {
        int rowsCount = inputArray1D.GetLength(0);     // Колличество строк
        double[] convertedInputArray = new double[rowsCount];

        for (int row = 0; row < rowsCount; row++)
        {
            convertedInputArray[row] = Convert.ToDouble(inputArray1D[row]);
        }
        return convertedInputArray;
    }



    static public int[,] ConvertArray2DToInt32<T>(T[,] inputArray2D)
    {
        int rowsCount = inputArray2D.GetLength(0);     // Колличество строк
        int collumsCount = inputArray2D.GetLength(1);  // Колличество столбцов
        int[,] convertedInputArray = new int[rowsCount, collumsCount];

        for (int row = 0; row < rowsCount; row++)
        {
            for (int collum = 0; collum < collumsCount; collum++)
            {
                convertedInputArray[row, collum] = Convert.ToInt32(inputArray2D[row, collum]);
            }
        }
        return convertedInputArray;
    }


    static public double[,] ConvertArray2DToDouble<T>(T[,] inputArray2D)
    {
        int rowsCount = inputArray2D.GetLength(0);     // Колличество строк
        int collumsCount = inputArray2D.GetLength(1);  // Колличество столбцов
        double[,] convertedInputArray = new double[rowsCount, collumsCount];

        for (int row = 0; row < rowsCount; row++)
        {
            for (int collum = 0; collum < collumsCount; collum++)
            {
                convertedInputArray[row, collum] = Convert.ToDouble(inputArray2D[row, collum]);
            }
        }
        return convertedInputArray;
    }

}

