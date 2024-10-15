using System;
using System.Globalization;
namespace ExerciceRaio {
    class Program {
        
        static void Main(string[] args) {
            Calculadora calculadora = new Calculadora();
            Console.Write("Entre o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cir = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);

            Console.WriteLine("Circunferência: "+cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));

        }
       
    }
}


