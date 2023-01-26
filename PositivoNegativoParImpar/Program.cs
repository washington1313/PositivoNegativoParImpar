using System;

namespace PositivoNegativoParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0 && numero > 0)
            {
                Console.WriteLine("Número Par / Positivo");
            }
            else if (numero % 2 == 0 && numero < 0)
            {
                Console.WriteLine("Número Par / Negativo ");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Zero é NEUTRO");
            }
            else if (numero % 2 == 1 && numero > 0)
            {
                Console.WriteLine("Número Ímpar / Positivo ");
            }
            else if (numero % 2 == -1 && numero < 0)
            {
                Console.WriteLine("Número Ímpar / Negativo ");
            }

            Console.ReadKey();
        }
    }
}
