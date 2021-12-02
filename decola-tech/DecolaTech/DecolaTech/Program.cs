using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecolaTech;
using Interface;

namespace DecolaTech
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Pedro";
            person.Idade = 32;
            person.Estado = "Recife";

            var person2 = new Pessoa();

            person2.Nome = "Géssica";
            person2.Idade = 32;
            person2.Estado = "Recife";

            Animal animal = new Animal();

            animal.Nome = "Laila";            
            animal.Dono = "Pedro";
            animal.Especie = "Cachorro";

        }
    }
}
