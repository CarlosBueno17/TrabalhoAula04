using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string client;
            string produto1;
            string produto2;
            int produ1;
            int produ2;






            Console.WriteLine("Bem-vindo ao sistema de estoque do Conradito");
            Console.WriteLine("Digite o nome do funcionário responsável:");
            client = Console.ReadLine();
            Console.WriteLine("\n \n");
            Console.WriteLine($"O cadastro de estoque será feito no nome de {client}");
            Console.WriteLine("\n \n");
            Console.WriteLine("-- CADASTRO DE PRODUTOS");
            Console.WriteLine("Digite o nome do Produto 1");
            produto1 = Console.ReadLine();
            Console.WriteLine("Digite a quantidade em estoque de Calça");
            produ1= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do Produto 2:");
            produto2 = Console.ReadLine();
            Console.WriteLine("Digite a quantidade em estoque de Perfume");
            produ2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n ");
            Console.WriteLine("- Os produtos foram cadastrados com sucesso!");
            Console.WriteLine("\n");
            Console.WriteLine($"-- LISTA DE PRODUTOS CADASTRADOS POR {client}:");
            Console.WriteLine($"- {produto1} contém {produ1} itens em estoque");
            Console.WriteLine($"- {produto2} contém {produ2} itens em estoque");
            Console.WriteLine($"- Total de itens no estoque:{produ1 + produ2}");
            Console.WriteLine("\n \n");
            Console.WriteLine("---- FIM DO SISTEMA -----");






            Console.ReadKey();
        }
    }
}
