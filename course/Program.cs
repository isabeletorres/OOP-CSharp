using System;

namespace Course {
    class Program {
        static void Main(string[] args){
            
            string[] vet =Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura);
            Console.WriteLine(idade);
        }
    }
}

