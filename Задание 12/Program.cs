using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {

        static void Main()

        {
            int r;

            Console.WriteLine("Введите радиус окружности");

            r = Convert.ToInt32(Console.ReadLine());

            Raschet ObjectRaschet = new Raschet();

            double result = ObjectRaschet.Area(r);

            Console.WriteLine("Площадь окружности {0:0.00}", result);


            double resultL = ObjectRaschet.LCicle(r);

            Console.WriteLine("Длина окружности {0:0.00}", resultL);

            int x,y;

            Console.WriteLine("Введите x, y");

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());


            bool resultP = ObjectRaschet.Points(x, y, r);

            Console.WriteLine("Вхождение точки в круг {0}", resultP);


            Console.ReadKey();
        }



    }

    class Raschet
    {

        public double Area(int r)// Вспомогательные методы
        {
            double area = r * r * Math.PI;
            return area;
        }

        public double LCicle(int r)
        {
            double LCicle = 2 * r * Math.PI;
            return LCicle;
        }


        public bool Points(int x, int y, double r)
        {
            if (x * x + y * y <= r * r)
            { return true; }
            else
            { return false; }

        }

    }

}










