using System;

namespace MatematicaUtil
{
    public class Calculador
    {
        /// <summary>
        /// Calcula o valor de Pi usando a Fórmula de Leibniz.
        /// </summary>
        /// <param name="iteracoes">Número de termos da série (quanto maior, mais preciso).</param>
        public static double CalcularPi(long iteracoes)
        {
            double pi = 0.0;
            double sinal = 1.0;

            for (long i = 0; i < iteracoes; i++)
            {
                pi += sinal / (2 * i + 1);
                sinal = -sinal; // Alterna o sinal (+ / -)
            }

            return pi * 4.0;
        }
    }
}
