using System;
using System.Linq;

public class AlgoritmosDeOrdenacao
{
    public static void BubbleSort(int[]array, bool crescente = true)
    {
        int n = array.Length;
        int comparacoes = 0;
        int trocas = 0;

        for (int i =0; i < n - 1; i++)
        {
            bool trocaRealizada = false;
            for  (int j =0; j < n - i - 1; j++)
            {
                comparacoes++;

                //Crescente: array[j] > array[j+1]
                //Decrescente: array[j] < array [j+1] 
                if ((crescente && array[j] > array[j+1])||
                (!crescente && array[j] < array[j+1]))
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    trocas ++;
                    trocaRealizada = true;
                }
                
            }
            if (!trocaRealizada)
            break;
        }

        Console.WriteLine($"\nTotal de Comparações: {comparacoes}");
        Console.WriteLine($"Total de Trocas: {trocas}");
    }
    public static void ImprimirArray(int[] array)
    {
        Console.WriteLine(string.Join(",", array));
    }

    public static void Main(string[] args)
    {
        int[] lista1 = {5,1,4,2,8};
        Console.WriteLine("Lista Original 1: ");
        ImprimirArray(lista1);

        BubbleSort(lista1,true); // true = crescente

        Console.WriteLine("n\Lista Ordenada 1 (Crescente): ");
        ImprimirArray(lista1);

        Console.WriteLine("-------------------------");

        int[] lista2 = {77,4,1,15,4,9,23};
        Console.WriteLine("Lista Original 2: ");
        ImprimirArray(lista2);

        BubbleSort(lista2,false);

        Console.WriteLine("\nLista Ordenada 2 (Crescente): ");
        ImprimitArray(lista2); 
    }
}
