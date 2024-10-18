using System;
using System.Globalization;

namespace ExerciceVetores3 {
    class Program {
        static void Main(string[] args) {

            Alunos[] vect = new Alunos[10];

            Console.Write("Quanto quartos serão alugados? ");
            int numQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numQuartos; i++) {
                Console.WriteLine();
                Console.WriteLine("Aluguel #{0}", i + 1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                
                vect[quarto] = new Alunos { Nome = nome, Email = email, Quarto = quarto };
            }
            Console.WriteLine();
            Console.WriteLine("Quartos oculpados: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": "+ vect[i]);
                }
            }
        }
    }
}