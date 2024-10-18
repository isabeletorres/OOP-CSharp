using RefOut;
using System;
using System.Globalization;

namespace ExerciceVetores3 {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            int triple;
            Console.WriteLine("Using Out");
            Calculator.Triple1(a, out triple);
            Console.WriteLine(triple);

            Calculator.Triple0(ref a);
            Console.WriteLine("Using Ref");
            Console.WriteLine(a);
            
        }
    }
}
