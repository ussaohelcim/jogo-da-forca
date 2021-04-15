using System;

namespace jogo_da_forca
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            Forca forcaJogo;
            forcaJogo = new Forca();
            while(continuar =='s')
            {
                forcaJogo.Inicio();
                Console.WriteLine("Quer inicar outro? (s ou n)");
                continuar = Console.ReadLine()[0];
            }

        }
        static void Teste()
        {

        }
    }
}
