using System;

namespace TeoremaDeTales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita as medidas dos segmentos do primeiro triângulo
            Console.WriteLine("Digite as medidas dos segmentos do primeiro triângulo:");
            double a1, b1, a2, b2;

            // Obtém as medidas dos segmentos do primeiro triângulo usando a função TryGetValidInput
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
                    Console.WriteLine($"Proporção entre os lados A: {proporcaoA:F2}");
                    Console.WriteLine($"Proporção entre os lados B: {proporcaoB:F2}");
                }
                else
                {
                    Console.WriteLine("Não é possível calcular a proporção quando um dos lados é zero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");
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
