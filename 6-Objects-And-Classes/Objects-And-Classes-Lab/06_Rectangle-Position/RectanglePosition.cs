using System;
using System.Linq;

public class RectanglePosition
{
    public static void Main()
    {
        Rectangle rect1 = ReadRectangle();
        Rectangle rect2 = ReadRectangle();

        Console.WriteLine(rect1.IsInside(rect2) ? "Inside" : "Not inside");
    }

    static Rectangle ReadRectangle()
    {
        int[] rectInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Rectangle rect = new Rectangle();
        rect.Left = rectInfo[0];
        rect.Top = rectInfo[1];
        rect.Width = rectInfo[2];
        rect.Height = rectInfo[3];

        return rect;
    }
}

public class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Right
    {
        get
        {
            return Left + Width;
        }
    }
    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }

    public int CalcArea()
    {
        return Width * Height;
    }

    public bool IsInside(Rectangle rect)
    {
        return (rect.Top <= Top) && (rect.Left <= Left) 
            && (rect.Bottom >= Bottom) && (rect.Right >= Right);
    }
}

