using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void Nome(String nome);
        void Dono(String nome);
        void Especie(String especie);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
        public String Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.Dono = nomeDono;
        }

        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }

    }
}
