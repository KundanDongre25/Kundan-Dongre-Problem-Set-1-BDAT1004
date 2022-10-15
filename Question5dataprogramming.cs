//Question 5a = Write a function inside(x, y, x1, y1, x2, y2) that returns True or False 
//depending on whether the point (x, y) lies in the rectangle with lower left 
//corner (x1, y1) and upper right corner (x2, y2).

using System;
using System.Drawing;

class GFG
{
    static bool FindPoint(int x1, int y1, int x2,
                          int y2, int x, int y)
    {
        if (x > x1 && x < x2 &&
            y > y1 && y < y2)
            return true;

        return false;
    }
    public static void Main()
    {
        int x1 = 0, y1 = 0,
            x2 = 2, y2 = 3;
        int x = 1, y = 1;
        if (FindPoint(x1, y1, x2, y2, x, y))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}

