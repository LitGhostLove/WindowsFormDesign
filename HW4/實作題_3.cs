public class Box
{
    // 成員變數（欄位）
    public double Width;
    public double Height;
    public double Length;

    // 建構子
    public Box(double width, double height, double length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    // 計算體積
    public double Volume()
    {
        return Width * Height * Length;
    }

    // 計算表面積
    public double Area()
    {
        return 2 * (Width * Height + Width * Length + Height * Length);
    }
}

+------------------------------+
|           Box                |
+------------------------------+
| - Width: double              |
| - Height: double             |
| - Length: double             |
+------------------------------+
| + Box(width, height, length) |
| + Volume(): double           |
| + Area(): double             |
+------------------------------+
