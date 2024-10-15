using System;
using System.Globalization;

namespace ExerciceRetangulo {
    class Program {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área: "+ retangulo.Area(). ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área: " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}




