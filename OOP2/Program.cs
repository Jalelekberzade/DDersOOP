using System;
using System.Threading.Channels;

namespace OOP2
{
    internal class Program
    { }


    public interface IShape
    {
        void CalculateArea();
        void CalculatePerimetr();
    }
    public class Square : IShape
    {

        public void CalculateArea()
        {
            Console.WriteLine("Kvadratin terefini daxil edin");
            double Side = double.Parse(Console.ReadLine());
            double Area = Side * Side;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine("Kvadratin terefini daxil edin");
            double Side = double.Parse(Console.ReadLine());
            double Perimetr = Side * 4;
        }
    }
    public class Circle : IShape
    {
        public void CalculateArea()
        {
            Console.WriteLine("Dairenin radiusunu daxil edin");
            double Radius = double.Parse(Console.ReadLine());
            double Area = Radius * Radius * Math.PI;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine("Dairenin radiusunu daxil edin");
            double Radius = double.Parse(Console.ReadLine());
            double Perimetr = Radius * 2 * Math.PI;
        }
    }
    public class Triangle : IShape
    {
        public void CalculateArea()
        {
            Console.WriteLine("Ucbucagin terefini daxil edin");
            double Side = double.Parse(Console.ReadLine());
            Console.WriteLine("Ucbucagin hundurluyunu daxil edin");
            double Height = double.Parse(Console.ReadLine());
            double Area = Side * Height / 2;
        }

        public void CalculatePerimetr()
        {
            Console.WriteLine("Ucbucagin birinci terefini daxil edin");
            double Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ucbucagin ikinci terefini daxil edin");
            double Side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ucbucagin ucuncu terefini daxil edin");
            double Side3 = double.Parse(Console.ReadLine());
            double Perimetr = Side1 + Side2 + Side3;

        }
    }
}


    



