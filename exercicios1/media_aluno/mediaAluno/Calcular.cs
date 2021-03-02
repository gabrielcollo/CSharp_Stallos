using System;
using System.Collections.Generic;
using System.Text;

namespace mediaAluno
{
    class Calcular
    {
        public double CalculoMedia(double somaNotas, int qtdNotas)
        {
            double media = somaNotas / qtdNotas;
            return media;
        }
    }
}