using System;
using System.Collections.Generic;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.IO;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo-teste.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};


            FileHelper helper = new FileHelper();
            
            helper.DeletarArquivo(caminhoArquivoTesteCopia);
            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá, teste de escrita de arquivo");
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);

            
            
            // ICalculadora calc = new Calculadora();

            // System.Console.WriteLine(calc.Somar(10, 20));
            
            // Computador computador = new Computador();
            // System.Console.WriteLine(computador.ToString()); 
            
            // Corrente conta = new Corrente();

            // conta.Creditar(100);

            // conta.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(2, 3));
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(2, 3, 6));
            
            
            // Aluno aluno = new Aluno();
            // aluno.Nome = "Jorge";
            // aluno.Idade = 28;
            // aluno.Nota = 9.5;
            // aluno.Documento = "82364823";

            // aluno.Apresentar();
            
            // Professor professor = new Professor();
            // professor.Nome = "Alfredo";
            // professor.Idade = 47;
            // professor.Salario = 3500.00;
            // professor.Documento = "63742034";
            
            // professor.Apresentar();
            // Retangulo r = new Retangulo();

            // r.DefinirMedidas(30, 30);
            // r.ObterArea();
            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // Retangulo r2 = new Retangulo();

            // r2.DefinirMedidas(0, 30);
            // r2.ObterArea();
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Pedro";
            // p1.Idade = 32;

            // p1.Apresentar();
        }
    }
}