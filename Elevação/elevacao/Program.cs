using System;

namespace elevacao
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declarar variaveis
    double num = 0, quad = 0, pot = 0;

           //Entrada
Console.Write("Digite um número: ");
num = Convert. ToDouble(Console.ReadLine( ));

Console.Write("Digite um número: ");
pot = Convert. ToDouble(Console.ReadLine( ));

           //Processamento
quad = Convert.ToDouble(Math.Pow(num, pot));

           //Saída
           Console.WriteLine("Elevacao=" + quad); 
        }
    }
}
