using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Jorge";
            aluno.Idade = 28;
            aluno.Nota = 9.5;
            aluno.Documento = "82364823";

            aluno.Apresentar();
            
            Professor professor = new Professor();
            professor.Nome = "Alfredo";
            professor.Idade = 47;
            professor.Salario = 3500.00;
            professor.Documento = "63742034";
            
            professor.Apresentar();
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