using System;

namespace Calculadora_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a Calculadora\n Digite o numero que quer calcular: ");
            int valor = int.Parse(Console.ReadLine());

            //int y = 0;
            for (int y = 0; y <= 10; y++)
            {
                int result = valor * y;
                Console.WriteLine($"O Resultado de {valor} x {y}: {result}");
            }






        }
    }
}
