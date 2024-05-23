using System;

class Point
{
    private int x;
    private int y;
    private string name;

    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    static public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
        }
        Console.WriteLine($"The perimeter of the {points.Length}-sided polygon is: {perimeter}");
    }

    public void ShowName()
    {
        Console.Write("Polygon: ");
        foreach (var point in points)
        {
            Console.Write(point.Name + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Point A = new(0, 0, "A");
        Point B = new(0, 3, "B");
        Point C = new(4, 3, "C");
        Point D = new(4, 0, "D");

        Figure triangle = new(A, B, C);
        Figure quadrilateral = new(A, B, C, D);

        triangle.ShowName();
        triangle.PerimeterCalculator();

        quadrilateral.ShowName();
        quadrilateral.PerimeterCalculator();
    }
}
