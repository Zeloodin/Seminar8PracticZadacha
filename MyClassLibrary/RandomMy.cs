namespace MyClassLibrary;
using System.Linq;


public class RandomMy
{
    static public double[] FillingAnArrayWithConsecutiveNumbers(int numLenght, ref double[] arrNum)
    {
        for (int n = 0; n < numLenght; n++)
        {
            arrNum[n] = n;
        }

        return arrNum;
    }


    ///RandomNextNoRepeat
    static public double[] GeneratorOfRandomNonRepeatingNumbersIntoAnArray(double[] arrNum, ref double[] listNumber)
    {
        double[] arrNumbers = arrNum;
        for (int i = 0; i < arrNum.Length; i++)
        {
            int rndTempNum = new Random().Next(0, arrNumbers.Length - i); // - i
            listNumber[i] = arrNumbers[rndTempNum];
            double tempNum = arrNumbers[rndTempNum];
            arrNumbers[rndTempNum] = arrNumbers[arrNumbers.Length - i - 1];
            arrNumbers[arrNumbers.Length - i - 1] = tempNum;

        }
        return listNumber;
    }

    static public double[] RandomNonRepeatingNumberGenerator(int lenghtNum)
    {
        int lenghtListNumber = lenghtNum;
        double[] arrayNumber = new double[lenghtListNumber];
        double[] listNumber = new double[lenghtListNumber];
        FillingAnArrayWithConsecutiveNumbers(numLenght: lenghtListNumber, ref arrayNumber);
        GeneratorOfRandomNonRepeatingNumbersIntoAnArray(arrNum: arrayNumber, listNumber: ref listNumber);
        return listNumber;
    }




    /// RandomNumberGeneratorPlusNumbersAfterDot
    static public double RandomNextPlus(int lengthOfDigitAfterDecimalPoint = 0, double fromMinNumber = 0.0, double toMaxNumber = 10.0)
    {
        return Math.Round(new Random().NextDouble() * (toMaxNumber - fromMinNumber) + fromMinNumber, lengthOfDigitAfterDecimalPoint);
    }





    static public double[] RandomNonRepeat(int CountNum = 5, double fromMinNumber = 0.0, double toMaxNumber = 10.0, int lenghtAfterPoint = 0, string type = "int")
    {

        double[] arrayNumbers = new double[CountNum];
        for (int i = 0; i < CountNum && i < Math.Abs(toMaxNumber - fromMinNumber); i++)
        {
            while (true)
            {
                if (i > arrayNumbers.Length)
                {
                    arrayNumbers[i] = 0;
                    break;
                }
                var randomNumber = 0.0;
                if (type.ToLower() == "double") randomNumber = RandomMy.RandomNextPlus(lenghtAfterPoint, fromMinNumber, toMaxNumber);
                else if (type.ToLower() == "doubleInt") randomNumber = Convert.ToDouble(Convert.ToInt32(RandomMy.RandomNextPlus(lenghtAfterPoint, fromMinNumber, toMaxNumber)));
                else if (type.ToLower() == "int") randomNumber = new Random().Next(Convert.ToInt32(fromMinNumber), Convert.ToInt32(toMaxNumber));
                else randomNumber = new Random().Next(Convert.ToInt32(fromMinNumber), Convert.ToInt32(toMaxNumber));

                bool isElementOfArray = false; // Этот элемент, нет в списке.
                foreach (double isNumberOfArray in arrayNumbers)
                {
                    if (isNumberOfArray == randomNumber)
                    {
                        isElementOfArray = true; // Если есть элемент в массиве, то, начинаем заново.
                    }
                }

                if (isElementOfArray) { }
                else
                {
                    arrayNumbers[i] = randomNumber;
                    break;
                }
            }
        }

        return arrayNumbers;
    }



}
