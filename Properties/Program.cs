using Sobrecarga;
using System;
using System.Globalization;
namespace Properties {
    class Program {
        static void Main(String[] args) {

            Prod p = new Prod("TV", 500.00, 10);

            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}