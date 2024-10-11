using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args){
            double xa, xb, xc, ya, yb, yc;
            
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double px = (xa + xb + xc) / 2;
            double py = (ya +yb + yc) / 2;

            double areaX = Math.Sqrt(px * (px - xa) * (px - xb) * (px - xc));
            double areaY = Math.Sqrt(py * (py - ya) * (py - yb) * (py - yc));

            Console.WriteLine($"Área de x= {areaX:F4}");
            Console.WriteLine($"Área de x= {areaY:F4}");

            if (areaX > areaY) {
                Console.WriteLine("Mior área: X");
            } else if (areaY> areaX) {
                Console.WriteLine("Mior área: y");
            } else {
                Console.WriteLine("As áreas são iguais");
            }
        }
    }
}

