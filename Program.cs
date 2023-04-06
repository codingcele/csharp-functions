// See https://aka.ms/new-console-template for more information

using System;

namespace Snacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero:");
            int numero = int.Parse(Console.ReadLine());
            int[] userArray = new int[numero];

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° numero: ");
                int num = int.Parse(Console.ReadLine());
                userArray[i] = num;
            }

            StampaArray(userArray);

            ElevaArrayAlQuadrato(userArray);

            int[] quadrati = ElevaArrayAlQuadrato(userArray);

            SommaElementiArray(userArray);

            SommaElementiArray(quadrati);
        }

        //snack 1
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

        //snack 2
        static int Quadrato(int numero)
        {;
            return numero * numero;
        }

        //snack 3
        static int[] ElevaArrayAlQuadrato(int[] array)
        {
            int[] copiaArray = (int[])array.Clone();
            for (int i = 0; i < copiaArray.Length; i++)
            {
                copiaArray[i] = Quadrato(copiaArray[i]);
            }
            StampaArray(copiaArray);
            StampaArray(array);
            return copiaArray;
        }

        //snack 4

        static int SommaElementiArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            StampaArray(array);
            Console.WriteLine(sum);
            return sum;
        }
    }
}

