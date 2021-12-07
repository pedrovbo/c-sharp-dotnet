namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = null!;
        public int Idade { get; set; }
        public string Documento { get; set; } = null!;
        
        public virtual void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos.");
        }

    }
}