namespace MyClassLibrary;

public class SearchInArray2DModes
{
    /// TODO
    static public string CompareSpecifiedAndSelectedItem<T>(T[,] inputArray, string elementToFind, int rows, int collums, ref int numberOfFoundElements, int mode = 0)
    {
        bool MatchesTheSpecifiedAndFoundElement = false;
        if (Convert.ToString(inputArray[rows, collums]) == elementToFind)
            MatchesTheSpecifiedAndFoundElement = true;

        switch (mode)
        {
            case 0: // out: an element in the array
                {
                    if (MatchesTheSpecifiedAndFoundElement)
                    {
                        numberOfFoundElements++;
                        return "";
                    }
                    return "";
                }

            case 1: // out: shows found items
                {
                    if (MatchesTheSpecifiedAndFoundElement)
                    {
                        numberOfFoundElements++;
                        return Convert.ToString(inputArray[rows, collums]) + "[_ss_[_ss_]_ss_]";
                    }
                    return "";
                }

            case 2: // out: shows found items with coordinates
                {
                    if (MatchesTheSpecifiedAndFoundElement)
                    {
                        numberOfFoundElements++;
                        return Convert.ToString($"{inputArray[rows, collums]}[_ia_[_ia_]_ia_]{rows}[_rc_[_rc_]_rc_]{collums}") + "[_ss_[_ss_]_ss_]";
                    }
                    return "";
                }

            /// TODO ArrayMy
            // case 3: // out: shows the element by coordinates
            // {
            //     numberOfFoundElements++;
            //     return Convert.ToString(inputArray[rows, collums]) + "[_ss_[_ss_]_ss_]";
            // }


            default:
                {
                    return "";
                }
        }
    }
}
