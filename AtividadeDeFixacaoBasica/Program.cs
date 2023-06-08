using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDeFixacaoBasica {
    internal class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco = 4999.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //imprimindo valores abaixo
            Console.WriteLine("Produtos: ");
            Console.WriteLine(produto1 + "," + " cujo o preço é $ " + preco.ToString("F1"));
            Console.WriteLine(produto2 + "," + "cujo o preço é $ " + preco2.ToString("F2"));
            Console.WriteLine("\n");
            Console.WriteLine("Registro: " + idade + " anos de idade," +" codigo " + codigo + " é gênero: " + genero);
            Console.WriteLine("\n");
            Console.WriteLine("Medida com oito casas decimais : " + medida.ToString("F8"));
            Console.WriteLine("Arredondando ( três casas decimais) : " +medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture : " + medida.ToString("F3",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
