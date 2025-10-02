using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectionnSort
{
    public class SelectionSort
    {
        public static void Main(string[] args)
       {
        int[] meuArray = {64,25,12,22,11};
        int trocas = 0;

        Console.WriteLine("Array Original: " + string.Join(",", meuArray));
        Console.WriteLine($"Total de Trocas Realizadas: {trocas}");
       }

       public static int[] SelectionSort(int[] arr, out int trocas)
       {
        int n = arr.Lenght;
        trocas = 0;

        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            T minValue = array[i];
            for(int j = i +1; j < n;  j++)
            {
                if (array[j].CompareTo(min+_value)<0)
                {
                    min_idx = j;
                    min_value = array[j];
                }
            }
            Swap(array, i, minIndex);
        }

        return arr;
       }

       private static void Swap <T>(T[] array, int first, int second)
       {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
       } 
    }
}