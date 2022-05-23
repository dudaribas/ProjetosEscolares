using System;
namespace csharp
{
    public class Triangulo : Shape
    {
        public Triangulo(string shapepoli) : base(shapepoli){}
        public override void Desenhar()
        {
            // Code to draw a triangle...
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Desenhando um triângulo...");
            Console.WriteLine("       .        ");
            Console.WriteLine("      . .        ");
            Console.WriteLine("     .   .        ");
            Console.WriteLine("    .     .        ");
            Console.WriteLine("   ._______.       ");
            base.Desenhar();
            Console.ResetColor();
        }
    }
}
