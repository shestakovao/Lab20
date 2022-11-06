using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = LengthCircle;
            Console.WriteLine("Длина окружности D = {0}",myDelegate(r));
            myDelegate = SquareCircle;
            Console.WriteLine("Площадь круга S = {0}", myDelegate(r));
            myDelegate = VolumeCircle;
            Console.WriteLine("Объём шара V = {0}", myDelegate(r));
            Console.ReadKey();
        }


        static double LengthCircle(double r) =>2 * Math.PI * r;
        static double SquareCircle(double r) => Math.PI * Math.Pow(r,2);
        static double VolumeCircle(double r) => 4.0/3.0* Math.PI * Math.Pow(r, 3);

    }
}
