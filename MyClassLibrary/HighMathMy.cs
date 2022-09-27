namespace MyClassLibrary;

public class HighMathMy
{
    ///TODO matrixArr1 edit value to<>, to Error: System.IndexOutOfRangeException
    static public double[,] MatrixMultiplitation(double[,] matrixArr1, double[,] matrixArr2)
    {
        // matrixArr1Y == matrixArr2X
        // matrixArr1.GetLength(1) == matrixArr2.GetLength(0)

        // matrixArr1 collum == matrixArr2 row
        // matrixArr1 row x matrixArr2 collum

        Console.WriteLine(matrixArr1.Length / matrixArr1.GetLength(1));
        Console.WriteLine(matrixArr1.GetLength(0));

        if (matrixArr1.Length / matrixArr1.GetLength(1) != matrixArr1.GetLength(0))
        {
            Console.WriteLine("У матрицы 1, столбцы не равны с рядами у матрицы 2");
            return matrixArr2;
        }
        else
        {
            double[,] matrixArrResult = new double[matrixArr2.GetLength(0), matrixArr2.GetLength(1)];
            for (int i = 0; i < matrixArr2.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < matrixArr2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixArr1.GetLength(0); k++)
                    {
                        sum += matrixArr1[i, k] * matrixArr2[k, j];
                        // Console.Write($"{matrixArr1[i,k]} * {matrixArr2[k,j]} = {matrixArr1[i,k] * matrixArr2[k,j]}\n");
                    }
                    matrixArrResult[i, j] = sum;
                    sum = 0;
                    // Console.WriteLine("Сброс суммы.");             
                }
            }
            return matrixArrResult;
        }
    }
}
