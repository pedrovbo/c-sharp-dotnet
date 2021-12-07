namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {this.Nome}. Sou um aluno de nota {this.Nota}");
        }
    }


}