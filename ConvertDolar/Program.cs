using System;
using System.Globalization;
using System.Net.WebSockets;

namespace ConvertDolar {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Qual é a cotação do dolar? ");
            double dolar = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            double qtdDolar = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.DolarParaReal(qtdDolar, dolar);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}