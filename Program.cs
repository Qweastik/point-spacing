using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dot dot = new Dot();

            dot.dot1();
        }
    }

    public class Dot
    {
        int x1;
        int y1;
        int x2;
        int y2;
        double distance;

        public double dot1 ()
        {
            {
                Console.WriteLine("введите координаты первой точки"  );
                Console.WriteLine("x1: ");
                x1 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("y1: ");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("введите координаты второй точки " );
                Console.WriteLine("x2: ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2: ");
                y2 = Convert.ToInt32(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine("расстояние между точками = " + distance);
                return distance;
            }
        } 

        
    }
}
