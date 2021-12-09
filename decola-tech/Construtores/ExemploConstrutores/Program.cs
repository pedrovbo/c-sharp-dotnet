using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno("Pedro", "Oliveira", "C# e .NET");
            aluno.Apresentar();
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