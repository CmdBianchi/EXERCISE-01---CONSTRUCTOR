using System;
namespace EXERCISE_CONSTRUCTOR {
    class Program {
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args) {
            Product p = new Product();

            Console.Write("Entre os dados do produto: ");
            Console.Write("Nome: "); p.Name = Console.ReadLine();
            Console.Write("Preço: "); p.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: "); p.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do produto: "+p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int amnt = int.Parse(Console.ReadLine());
            p.AddProduct(amnt);

            Console.WriteLine();
            Console.WriteLine("Dados att: "+p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            amnt = int.Parse(Console.ReadLine());
            p.RemoveProduct(amnt);

            Console.WriteLine();
            Console.WriteLine("Dados att: "+p);
            Console.WriteLine();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
