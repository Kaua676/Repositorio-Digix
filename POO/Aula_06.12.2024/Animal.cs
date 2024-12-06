using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06._12._2024
{
    public record class Animal
    {
        public boolean Vivo

        public Animal(boolean vivo)
        {
            this.Vivo = vivo;
        }

        public virtual void Imprimir()
        {
            System.Console.WriteLine("Animal: " + Vivo);
        }
    }

}