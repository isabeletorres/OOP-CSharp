using Sobrecarga;
using System;
using System.Globalization;
namespace Sobrecarga {
    class Program {
        static void Main(String[] args) {

            Produt p = new Produt("TV", 500.00, 10);

            p.SetNome("T");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}