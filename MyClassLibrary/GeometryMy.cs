namespace MyClassLibrary;

public class GeometryMy
{
    static public double[] CrossPoint(double k1, double b1, double k2, double b2)
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        double[] xy = new double[] { x, y };
        if (k1 == k2) return xy;
        else return xy;
    }

    static public string IsNanOrIsInfinity(double x, double y)
    {
        if (Double.IsNaN(x) || Double.IsInfinity(x) ||
            Double.IsNaN(y) || Double.IsInfinity(y)) return "Заданные прямые не пересекаются.";
        else return $"({x}; {y})";
    }
}
