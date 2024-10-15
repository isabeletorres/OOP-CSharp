using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRetangulo {
    internal class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura* Altura;
        }
        public double Perimetro (){
            return (Altura + Largura) * 2;
        }
        public double Diagonal() {
            return Math.Sqrt((Largura*Largura) +( Altura*Altura));
        }

    }
}
