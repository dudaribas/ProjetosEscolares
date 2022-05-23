using System;
namespace csharp
{
    public class Circle : Shape
    {
        public Circle(string shapepoli) : base(shapepoli){}
        public override void Desenhar()
        {
            // Code to draw a circle...
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Desenhando um círculo...");
            Console.WriteLine("       .....       ");
            Console.WriteLine("     .       .       ");
            Console.WriteLine("    .         .       ");
            Console.WriteLine("     .       .       ");
            Console.WriteLine("       .....       ");
            base.Desenhar();
            Console.ResetColor();
        }
    } 
}
        