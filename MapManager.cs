using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    // A classe utiliza o código de uma das aulas do professor e foi adaptado
    // para gerar o mapa de acordo com a resposta do utilizador
    public class MapManager
    {
        #region MapGen
        public static void MapGen()
        {
            Game.StartTela();

            #region Variáveis de Classe
            // Declaração de variáveis
            int numLinhas, numColunas;
            string resposta;
            int[,] grelha;
            float somaDasMedias = 0;
            #endregion

            #region Perguntas para o utilizador
            // Pede o número de linhas e converte para inteiro
            Console.Write("Insira o número de linhas da grelha de jogo: ");
            resposta = Console.ReadLine();
            numLinhas = Convert.ToInt32(resposta);

            // Pede o número de colunas e converte para inteiro
            Console.Write("Insira o número de colunas da grelha de jogo: ");
            resposta = Console.ReadLine();
            numColunas = Convert.ToInt32(resposta);
            Console.Clear();
            #endregion

            #region Array Bidimensional
            // Inicializa a grelha (array bidimensional)
            grelha = new int[numLinhas, numColunas];

            // Console.WriteLine para início de jogo.
            WriteLines.Game_StartGame();
            #endregion

            #region For Loop
            // Percorre linhas
            for (int rows = 0; rows < numLinhas; rows++)
            {
                // Percorre colunas
                for (int cols = 0; cols < numColunas; cols++)
                {
                    Console.Write('=');
                }
                // Depois que é preenchido 1 cols, preenche 1 rows.
                Console.WriteLine('=');
            }
            #endregion

            #region For loop

            // Percorre linhas
            /*for (int i = 0; i < numLinhas; i++)
            {
                // Declaração e inicialização da variável onde vamos 
                // guardar a soma dos valores na linha atual
                float somaDaLinha = 0;
                float mediaDaLinha;

                // Mostrar caráter de início de linha
                Console.Write("=");

                // Percorrer colunas
                for (int j = 0; j < numColunas; j++)
                {
                    // Mostrar o valor na linha/coluna atuais
                    Console.Write("=", grelha[i, j]);

                    // Adicionar valor atual à soma da linha atual
                    somaDaLinha += grelha[i, j];
                }

                // Mostrar caráter de fim de linha da grelha
                Console.Write("#");
                mediaDaLinha = somaDaLinha / numColunas;

                // Mostra o exit
                Console.WriteLine("EXIT!");
                somaDasMedias += mediaDaLinha;
            }*/

            // Mostrar soma das médias
            Console.WriteLine(" ");
            #endregion 
        }
        #endregion
    }
}