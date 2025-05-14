public static int Cube(int n)
{
    return n * n * n;
}

public static double Cube(double n)
{
    return n * n * n;
}

public static int MinElement(int a, int b, int c)
{
    return Math.Min(a, Math.Min(b, c));
}

public static int MinElement(int a, int b, int c, int d)
{
    return Math.Min(a, Math.Min(b, Math.Min(c, d)));
}