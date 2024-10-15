using Sobrecarga;
using System;
using System.Globalization;
namespace Sobrecarga {
    class Program {
        static void Main(String[] args) {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produt p = new Produt(nome, preco);

            Produt p2 = new Produt {
                Nome = "TV",
                Preco = 500,
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qtdremove = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtdremove);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

        }
    }
}