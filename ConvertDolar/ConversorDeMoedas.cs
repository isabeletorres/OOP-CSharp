using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDolar {
    internal class ConversorDeMoedas {
        public static double IOF = 0.06;

        public static double DolarParaReal(double cotacao, double quantia) {
            double total = cotacao * quantia;
            return total + (IOF * total);
        }
    }
}
