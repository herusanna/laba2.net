using System;
using System.Collections.Generic;
using System.Text;

namespace laba2.net
{
    class Quadrangles
    {
        Quadrangle[] quadrangle;
        internal Quadrangle[] Quadran { get => quadrangle; set => quadrangle = value; }
        public Quadrangles()
        { }
        public Quadrangles(int N)
        {
            Console.WriteLine("Enter the number of quadrangles: ");
            N = Convert.ToInt32(Console.ReadLine());
            Quadran = new Quadrangle[N];
            //Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                Quadran[i] = new Quadrangle();
                Console.WriteLine($"{i+1} quadrangle's data:");
                Quadran[i].getSide();
            }
            Console.WriteLine();
        }
        public void printQuadrangles()
        {
            int i = 1;
            foreach (Quadrangle quadrangle in Quadran)
            {
                //Console.WriteLine(i++ + ": " + quadrangle.side);
                Console.WriteLine($"{i++} Area: {String.Format("{0:0.00}", quadrangle.getArea())}");
            }
            Console.WriteLine();
        }
        public double findAverageArea()
        {
            double average = 0;
            double sum = 0;
            if (Quadran.Length > 0)
            {
                for (int i = 0; i < Quadran.Length; i++)
                {
                    sum += Quadran[i].getArea();
                }
                average = sum / Quadran.Length;
            }
            return average;
        }
    }
}
