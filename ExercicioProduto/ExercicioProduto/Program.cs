using ExercicioProduto;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + produto);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.Write("Digite a quantidade de produtos a ser adicionado ao estoque: ");
            int novaQuantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(novaQuantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + produto);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Digite a quantidade de produtos a ser removido do estoque: ");
            int removeQuantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(removeQuantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + produto);

        }

    }

}

