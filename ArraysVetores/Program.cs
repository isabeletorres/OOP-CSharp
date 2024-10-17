using System;
using System.Globalization;

namespace ArraysVetores {
    class Program {
        static void Main(string[] args) {
            double soma = 0;
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i <vect.Length; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[i];
            }
            double avg = soma/vect.Length;
            Console.WriteLine("AVERAGE HEIGHT= "+ avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}