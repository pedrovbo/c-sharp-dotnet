namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo += valor; // faz a mesma coisa que o this, contudo fica mais 
                                // semantico usar o base para indicar que é usado da classe pai
        }
    }
}