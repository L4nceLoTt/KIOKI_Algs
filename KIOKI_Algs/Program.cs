
using KIOKI_Algs;
using System.Collections.ObjectModel;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        string msg = "Ёбаный бобаный, Ну раз уж на то пошло, _то можно i po polnoй RazГуляться";

        string encr = Algs.RotatingGrateEncrypt(msg, new Point[] { new Point(0, 0), new Point(0, 3), new Point(2, 2), new Point(3, 1) });
    }
}