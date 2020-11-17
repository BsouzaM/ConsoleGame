using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    public class HighScore
    {
        #region HighScore
        // Mostra a pontuação em ordem decrescente
        public static void MostrarPontuacao()
        {
            // Array de pontuações máximas: 0, 1, 2, 3, 4.
            int[] pontuacao = new int[5];

            // Pega a pontuação do jogo (menor que 5 para evitar problemas)
            for (int i = 1; i < 5; i++)
            {
                Console.Write("Digite o score do jogo " + i + ": ");
                pontuacao[i] = int.Parse(Console.ReadLine());
            }

            // Organiza as pontuações com o .Sort
            Array.Sort(pontuacao);
            WriteLines.HighScore_MostrarPontuacao();

            // Mostra a pontuação de maior para menor
            for (int i = 4; i >= 1; i--)
            {
                // Vamos imprimir no console as pontuações em ordem decrescente.
                Console.WriteLine(pontuacao[i].ToString());
            }
        }
        #endregion
    }
}