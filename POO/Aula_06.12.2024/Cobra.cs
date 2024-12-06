using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06._12._2024
{
    public record class Cobra : Animal
    {
        private boolean Venenosa

        public Cobra(boolean vivo, boolean venenosa) : base(vivo)
        {
            this.Venenosa = venenosa;
        }

        public void Alimento(string a)
        {
            System.Console.WriteLine($"Se alimenta de {a}\n");
        }

        public void setVenenosa(boolean v)
        {
            this.Venenosa = v
        }
    }
}