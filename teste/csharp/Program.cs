using System;

namespace csharp{

    class Program{
        static void Main(string[] args)
        {
            Shape[] form = new Shape[4];

            form[0] = new Circle("");
            form[1] = new Retangulo("");
            form[2] = new Quadrado("");
            form[3] = new Triangulo("");

            int i = 0;
           do
           {
               Console.WriteLine("\nQue forma tu queres? ");
                Console.WriteLine("[0] - Circulo  [1] - Retângulo [2] - Quadrado  [3] - Triangulo");
                int n = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nCriando a classe base para desenhar...");
                Desenhando(form[n]);

                
                Console.WriteLine("\n[1] - tentar outra forma  [2] - sair");
                i = Convert.ToInt32(Console.ReadLine());
                
           }
           while(i == 1);
            
            // Desenhando(form[1]);
            // Desenhando(form[2]);
            // Desenhando(form[3]);
        }

        public static void Desenhando(Shape form)
        {
            Console.WriteLine(form.Poli);
            form.Desenhar();
        }
    }
}