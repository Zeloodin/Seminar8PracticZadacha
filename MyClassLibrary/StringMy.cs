namespace MyClassLibrary;

public class StringMy
{
    static public string ConsoleRead(string writeText = "")
    {
        if(writeText != "") Console.Write(writeText);
        return Convert.ToString(Console.Read());
    }

    static public void ConsoleWrite(string writeText = "", string spaceEnd = "")
    {
        Console.Write(writeText + spaceEnd);
    }

    // Выбирает строку по диапазону minIndex, maxIndex, и возращает её.
    static public string SelectedNumberFromIndexMinToMax(string inputString, int minIndex, int maxIndex)
    {
        string strRangeIndexMinMax = string.Empty;
        for (int i = minIndex; i <= maxIndex; i++)
        {
            strRangeIndexMinMax += inputString[i];
        }
        return strRangeIndexMinMax;
    }
}
