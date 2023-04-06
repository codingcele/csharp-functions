// See https://aka.ms/new-console-template for more information

using System;

namespace Snacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = { 1, 2, 3, 4, 5, 12, 17, 11, 28, 10 };
            StampaArray(numeri);

            int num = 9;

            Quadrato(num);
        }

        static void StampaArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("]");
        }

        static int Quadrato(int numero)
        {
            Console.WriteLine(numero * numero);
            return numero * numero;
        }
    }
}

