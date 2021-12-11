using System;

using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9};
            int[] arrayCopia = new int[10];
            
            int valorProcurado = 3;

            int indice = op.ObterIndice(array, valorProcurado);

            if (indice > -1)
            {
                System.Console.WriteLine($"O índice do elemento {valorProcurado} é: {indice}");
            }
            else
            {
                System.Console.WriteLine("Valor não existente no array");
            }
            
            // int valorAchado = op.ObterValor(array, valorProcurado);
            
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }
            // bool todosMaiorQue = op.TodoMaiorQue(array, valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maior que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maior do que {0}", valorProcurado);
            // }
            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {   
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original: ");
            // op.ImprimirArray(array);

            // op.OrdernarBubbleSort(ref array);
            // op.Ordenar(ref array);


            // System.Console.WriteLine("Array ordenado:");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia:");
            // op.ImprimirArray(arrayCopia);
            
            // int[,] matriz = new int[4, 2]
            // {
            //     {8 , 8},
            //     {10, 20}, 
            //     {50, 100}, 
            //     {90, 200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }



            // matriz[0, 0] = 5;

            
            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");

            // System.Console.WriteLine("Percorrendo o array pelo For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}