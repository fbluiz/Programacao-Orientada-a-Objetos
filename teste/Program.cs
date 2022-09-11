using System;
using System.Globalization;
using System.Xml.Schema;
using teste;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade do Estoque");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Dados do Produto:  " + p);

            Console.WriteLine();
            Console.WriteLine("Digita o Número de Produtos a ser Adicionados ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarQuantidade(qte);
            Console.WriteLine("Dados atualizados: " + p );


            Console.WriteLine();
            Console.WriteLine("Digita o Número de Produtos a ser Removidos ao estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverQuantidade(qte);
            Console.WriteLine("Dados atualizados: " + p);




        }
    }
}