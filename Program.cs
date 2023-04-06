// See https://aka.ms/new-console-template for more information

using System;

namespace Snacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = { 1, 2, 3, 4, 5, 12, 17, 11, 28, 10 };
            //StampaArray(numeri);

            //int num = 9;

            //Quadrato(num);

            //ElevaArrayAlQuadrato(numeri);

            SommaElementiArray(numeri);
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
        {
            Console.WriteLine(numero * numero);
            return numero * numero;
        }

        //snack 3
        static int[] ElevaArrayAlQuadrato(int[] array)
        {
            int[] copiaArray = (int[])array.Clone();
            for (int i = 0; i < copiaArray.Length; i++)
            {
                copiaArray[i] = copiaArray[i] * copiaArray[i];
            }
            StampaArray(copiaArray);
            StampaArray(array);
            return copiaArray;
        }

        //snack 4

        static int SommaElementiArray(int[] array)
        {
            int[] copiaArray = (int[])array.Clone();
            int sum = 0;
            for (int i = 0; i < copiaArray.Length; i++)
            {
                sum += copiaArray[i];
            }
            StampaArray(copiaArray);
            StampaArray(array);
            Console.WriteLine(sum);
            return sum;
        }
    }
}

