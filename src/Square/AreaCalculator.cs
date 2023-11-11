namespace Square;

public static class AreaCalculator
{
    public static double CircleArea(double radius)
    {
        return radius * radius * Math.PI;
    }

    public static double TriArea(double a, double b, double c)
    {
        if (a + b < c || a + c < b || b + c < a)
            return 0;
        
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
}