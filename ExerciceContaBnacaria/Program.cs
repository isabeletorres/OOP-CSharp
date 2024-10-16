using ExerciceContaBnacaria;
using System;
using System.Globalization;

namespace ExerciceContaBancaria {
    class Program {
        public static void Main(string[] args) {
            ContaBancaria1 contaB;


            Console.Write("Entre o número na conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial? (s/n)");
            char res = char.Parse(Console.ReadLine());

            if (res == 'S' || res == 's') {
                Console.Write("Entre o valor de deposito incicial: ");
                double depI = double.Parse(Console.ReadLine());
                contaB= new ContaBancaria1(numConta, nome, depI);
            }
            else {
                contaB = new ContaBancaria1(numConta, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Ddos da conta: ");
            Console.WriteLine(contaB);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine()); 
            contaB.Deposito(deposito);
            Console.WriteLine("Ddos da conta atualizados: ");
            Console.WriteLine(contaB);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            contaB.Saque(saque);
            Console.WriteLine("Ddos da conta atualizados: ");
            Console.WriteLine(contaB);

        }
    }
}