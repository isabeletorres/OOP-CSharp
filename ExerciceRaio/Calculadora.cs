﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRaio {
    internal class Calculadora {
        public static double pi = 3.14;
        public static double Circunferencia(double raio) {
            return 2 * pi * raio;
        }
        public static double Volume(double raio) {
            return 4.0 / 3 * pi * Math.Pow(raio, 3);
        }
    }
}
