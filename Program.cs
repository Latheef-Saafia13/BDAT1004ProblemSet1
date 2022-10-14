using System;
public class AreaOfTriangle
{
    public static void Main()
    {
       

        program(1, 2, 3.5, 4.6, 7.8, 5.8, 3.0, 7.9, 6.6, 2.3);

    }
    public static void program(int x, int y, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        if (x > x1 && x < x2 && y > y1 && y < y2)
        {
            if (x > x3 && x < x4 && y > y3 && y < y4)
            {
                Console.WriteLine("True");
            }
        }
        else
            Console.WriteLine("False");}
}
