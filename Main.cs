using System;

namespace TeoremaDeTales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita as medidas dos segmentos do primeiro triangulo
            Console.WriteLine("Digite as medidas dos segmentos do primeiro triangulo:");
            double a1, b1, a2, b2;

            // Obtém as medidas dos segmentos do primeiro triangulo usando a função TryGetValidInput
            if (TryGetValidInput(out a1) && TryGetValidInput(out b1) &&
                TryGetValidInput(out a2) && TryGetValidInput(out b2))
            {
                // Verifica se os denominadores não são zero antes de calcular as proporções
                if (b1 != 0 && b2 != 0)
                {
                    // Calcula as proporções
                    double proporcaoA = a1 / a2;
                    double proporcaoB = b1 / b2;

                    // Exibe as proporções formatadas com duas casas decimais
                    Console.WriteLine($"Proporcao entre os lados A: {proporcaoA:F2}");
                    Console.WriteLine($"Proporcao entre os lados B: {proporcaoB:F2}");
                }
                else
                {
                    Console.WriteLine("Nao é possível calcular a proporção quando um dos lados e zero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida. Certifique-se de inserir numeros validos.");
            }
        }

        // Função para obter um valor válido do usuário
        static bool TryGetValidInput(out double value)
        {
            Console.Write("Digite um valor: ");
            return double.TryParse(Console.ReadLine(), out value) && value != 0;
        }
    }
}
