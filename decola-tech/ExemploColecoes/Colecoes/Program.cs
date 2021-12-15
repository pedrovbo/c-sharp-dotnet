using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();
            
            System.Console.WriteLine($"Mínimo: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string");


            // var numerosParesQuery = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x =>).ToList();

            // System.Console.WriteLine("Números pares query: " + string.Join(",", numerosParesQuery));
            // System.Console.WriteLine("Números pares método: " + string.Join(",", numerosParesMetodo));
            
            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            
            // string valorProcurado = "SC";

            // var teste = estados["SC"];

            // if(estados.TryGetValue(valorProcurado, out string? estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
            // }

            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

            // estados.Remove(valorProcurado);

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // System.Console.WriteLine("Valor original:");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = " BA - teste atualização";

            // System.Console.WriteLine("Valor atualizado:");
            // System.Console.WriteLine(estados[valorProcurado]);
            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Código Limpo");

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");
            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }
            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Eduardo");
            // fila.Enqueue("André");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // string[] estadosArray = new string[2] {"SC", "MT"};
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>() {"SP", "MG", "BA"};
            
            // System.Console.WriteLine($"Quantidade de elemetnos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento");
            
            // estados.Remove("MG");

            // estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");

            // opLista.ImprimirListaString(estados);
            
            


            
            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] { 6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);
            
            // // int valorProcurado = 3;

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
            
            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade após redimensionar o array: {array.Length}");
                        
            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine($"O índice do elemento {valorProcurado} é: {indice}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }
            
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