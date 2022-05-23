using System;
namespace csharp
{
    public class Quadrado : Shape
    {
        public Quadrado(string shapepoli) : base(shapepoli){}
        public override void Desenhar()
        {
            // Code to draw a triangle...
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Desenhando um quadrado...");
            Console.WriteLine(" ________");
            Console.WriteLine("|        |");
            Console.WriteLine("|        |");
            Console.WriteLine("|________|");
            base.Desenhar();
            Console.ResetColor();
        }
    }
}