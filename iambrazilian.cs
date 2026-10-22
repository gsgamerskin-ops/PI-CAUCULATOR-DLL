using System;
using MatematicaUtil; // Namespace da sua DLL

class Program
{
    static void Main(using System; 

namespace picalc 
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
)
/// THIS CODE IS FAILED , IF YOU WANT FIX IT , I AM LAZY TO DO THIS
    {
        Console.WriteLine("--- Testando a DLL picalc.dll ---");
        
        long iteracoes = 1000000; // 1 milhão de iterações
        Console.WriteLine("Calculando Pi com {0} iterações...", iteracoes);
        
        // Chama o método da sua DLL
        double resultado = Calculador.CalcularPi(iteracoes);
        
        Console.WriteLine("Resultado obtido: {0}", resultado);
        Console.WriteLine("Valor real de Pi: {0}", Math.PI);
        Console.WriteLine("Diferença:       {0}", Math.Abs(Math.PI - resultado));
        
        Console.ReadLine();
    }
}
