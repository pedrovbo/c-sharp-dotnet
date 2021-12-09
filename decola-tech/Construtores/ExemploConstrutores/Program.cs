using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void operacao(int x, int y);
        static void Main(string[] args)
        {
            // operacao op = Calculadora.Somar;
            operacao op = new operacao(Calculadora.Somar);
            op.Invoke(10, 20);
            op(20,30);


            // const double pi = 3.14;
            // System.Console.WriteLine(pi);
            
            // Data data = new Data();
            // data.Mes = 4;
            // data.ApresentarMes();
            // System.Console.WriteLine(data.Mes);

                        
            // Aluno aluno = new Aluno("Pedro", "Oliveira", "C# e .NET");
            // aluno.Apresentar();
            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Log log = new Log();
            
            // Pessoa p1 = new Pessoa("Pedro", "Oliveira");
            // p1.Apresentar();
        }
    }
}