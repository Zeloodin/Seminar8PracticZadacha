using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoMyLibrary;
public class SortNoMy
{
    public static double[,] SortArray2D(double[,] inputArray)
    {

        int n = inputArray.GetLength(0);
        int m = inputArray.GetLength(1);
        double[,] arr = inputArray;
        int indi = 0;
        double max = arr[indi, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    indi = i;
                }
        double tmp;
        for (int k = 0; k < arr.GetLength(1); k++)
            for (int p = k + 1; p < arr.GetLength(1); p++)
                if (arr[indi, k] < arr[indi, p])
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        tmp = arr[i, p];
                        arr[i, p] = arr[i, k];
                        arr[i, k] = tmp;
                    }
                }
        return arr;
    }


    public static string SortArray2DDown(double[,] input2DArray)
    {
        var arr = input2DArray.Cast<double>().OrderByDescending(a => a).ToArray();
        int c = 0;
        string strArray2d = string.Empty;
        for (int j = 0; j < input2DArray.GetLength(0); j++)
        {
            for (int k = 0; k < input2DArray.GetLength(1); k++)
            {
                input2DArray[j, k] = arr[c];
                strArray2d += (input2DArray[j, k] + " ");
                c++;
            }
            strArray2d += "\n";
        }
        return strArray2d;
    }


}
