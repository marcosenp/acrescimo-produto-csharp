using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor do produto:");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal valorProduto) && valorProduto > 0)
        {
            decimal valorComAcrescimo = valorProduto * 1.10m; 
            Console.WriteLine($"Novo valor do produto: {valorComAcrescimo:F2}");
        }
        else
        {
            Console.WriteLine("Número inválido, tente novamente.");
        }
    }
}
