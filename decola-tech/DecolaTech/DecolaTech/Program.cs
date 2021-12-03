using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Enum;
using Classes;
using Primeiro;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.José;
            Pessoas pessoa3 = (Pessoas)4;

            Console.WriteLine(pessoa1 + " " + pessoa2 + " " + pessoa3);

            Pessoa person = new Pessoa();

            person.Nome = "Pedro";
            person.Idade = 32;
            person.Estado = "Recife";

            Console.WriteLine(person.Nome.ToString());

            var person2 = new Pessoa();

            person2.Nome = "Géssica";
            person2.Idade = 32;
            person2.Estado = "Recife";

            Animal animal = new Animal();

            animal.Nome = "Laila";            
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();


        }
    }
}
