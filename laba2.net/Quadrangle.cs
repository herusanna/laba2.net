using System;
using System.Collections.Generic;
using System.Text;

namespace laba2.net
{
    public struct point2D
    {
        public int x;
        public int y;
    }
    public class Quadrangle
    {
        point2D[] points;
        public double[] side;
        public double[] diagon=new double[2];
        public double[] angle = new double[2];
        Random r = new Random();
        int size = 4;
        //int diagonSize = 2;
        public Quadrangle()
        {
            
            this.points = new point2D[4];
          
            for (int i = 0; i < points.Length; i++)
            {
               points[i].x =  r.Next(-5,5);
               points[i].y =  r.Next(-5,5);

            }
        }
        public void Show()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("Координаты точки: х = {0}, у = {1}",points[i].x, points[i].y);
                Console.WriteLine();
            }
        }

        public void getSide()
        {
            side = new double[4];
            for (int i = 0; i < points.Length; i++)
            {
                side[i] = Math.Sqrt(Math.Pow(points[(i + 1)%size].x - points[i].x, 2) + Math.Pow(points[(i + 1)%size].y - points[i].y, 2));
                Console.Write($"{i+1} side :  {String.Format("{0:0.00}", side[i])}   ");
            }
            Console.WriteLine();
        }
        public void exist()
        {
            if (side[0] < side[1] + side[2] + side[3])
            {
                if (side[1] < side[0] + side[2] + side[3]) 
                {
                    if (side[2] < side[0] + side[1] + side[3])
                    {
                        if (side[3] < side[0] + side[1] + side[2])
                            Console.WriteLine("Correct sides");
                        else
                            Console.WriteLine("Incorrect sides");
                    }
                }
            }
        }
         public double getPerimetr()
        {
            return side[0] + side[1] + side[2] + side[3];
        }

        public double getArea()
        {
            double p = getPerimetr() / 2;
            return Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]) * (p - side[3]));
        }
        public void getAngle()
        {
            for (int i = 0; i < 2; i++)
            {
                angle[i] = (points[(i + 1) % size].x * points[i].x + points[(i + 1) % size].y * points[i].y) / (side[i] * side[(i + 1) % size]);
            } 
        }
        public void getDiagon()
        {
            for (int i = 0; i < 2; i++)
            {
                diagon[i] = Math.Sqrt(Math.Pow(side[i], 2) + Math.Pow(side[(i+1)%size], 2) - 2 * side[i] * side[(i+1)%size] * angle[i]);
                Console.WriteLine($"Diagonal {i+1}: {String.Format("{0:0.00}",diagon[i])}");
            }
        }
        /*
        public void printQuadrangle()
        {
            Console.WriteLine($"Sides: { String.Format("{0:0.00}", side[0])} , { String.Format("{0:0.00}", side[1])} , { String.Format("{0:0.00}", side[2])} , { String.Format("{0:0.00}", side[3])}");
            Console.WriteLine($"Perimetr: {String.Format("{0:0.00}", getPerimetr())}");
            Console.WriteLine($"Area: {String.Format("{0:0.00}", getArea())}");
            Console.Write($"Diagonal: {String.Format("{0:0.00}", diagon[0])},{String.Format("{0:0.00}", diagon[1])}");
        }
        */
    }
}
 