// See https://aka.ms/new-console-template for more information

using System;

namespace Snacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = { 2, 6, 7, 5, 3, 9 };

            StampaArray(numeri);

            int num = 9;

            Quadrato(num);

            ElevaArrayAlQuadrato(numeri);

            int[] quadrati = ElevaArrayAlQuadrato(numeri);

            SommaElementiArray(numeri);

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

