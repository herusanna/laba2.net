using System;

namespace laba2.net
{
    class Program
    {
            static void Main(string[] args)
        {
            Quadrangle quadrangle = new Quadrangle();
            quadrangle.Show();
            Console.WriteLine($"Sides: ");
            quadrangle.getSide();
            Console.WriteLine($"Existence: ");
            quadrangle.exist();
            Console.WriteLine();
            Console.WriteLine($"Perimetr: {String.Format("{0:0.00}", quadrangle.getPerimetr())}");
            Console.WriteLine($"Area: {String.Format("{0:0.00}", quadrangle.getArea())}"); 
            quadrangle.getDiagon();
            Console.WriteLine();
            //quadrangle.printQuadrangle();
            Quadrangles quadrangles = new Quadrangles(20);
            quadrangles.printQuadrangles();
            Console.WriteLine($"Average perimetr: {String.Format("{0:0.00}", quadrangles.findAveragePerimetr())}");
        }

    }
}
