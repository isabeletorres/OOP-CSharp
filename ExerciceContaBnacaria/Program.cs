using ExerciceContaBnacaria;
using System;
using System.Globalization;
using System.Xml;

namespace ExerciceContaBancaria {
    class Program {
        public static void Main(string[] args) {
            char res;
            ContaBancaria1 conta;
            
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá deposito inicial? [S/N] ");
            res = char.Parse(Console.ReadLine());

            if (res == 'S' || res == 's') {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoIn = double.Parse(Console.ReadLine());
                conta = new ContaBancaria1(numConta, nomeTitular, depositoIn);
            }
            else {
                conta = new ContaBancaria1(numConta, nomeTitular);
            }
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}