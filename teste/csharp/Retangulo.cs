using System;
namespace csharp
{
    
    public class Retangulo : Shape
    {
        public Retangulo(string shapepoli) : base(shapepoli){}
        public override void Desenhar()
        {
            // Code to draw a rectangle...
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Desenhando um retângulo...");
            Console.WriteLine(" ___________________");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|___________________|");
            base.Desenhar();
            Console.ResetColor();
        }
    } 
}
