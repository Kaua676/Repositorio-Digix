using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06._12._2024
{
    public record class Javali : Animal
    {
        private boolean Selvagem

        public Javali(boolean vivo, boolean selvagem) : base(vivo)
        {
            this.Selvagem = selvagem;
        }

        public int getVelocidadeMaxima()
        {
            return 40;
        } 

        public setSelvagem(boolean s)
        {
            this.Selvagem = s
        }
    }
}