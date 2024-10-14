using System;
using System.Globalization;
namespace ExercicesProduct {
    class Program {
        static void Main(String[] args) {
            Product p = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: "+ p);
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