using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    public class MenuInicial
    {
        #region Menu
        public static void Menu()
        {
            #region Inicialização do Programa
            // Menu inicial.
            Console.Clear();
            WriteLines.MenuInicial_Menu();
            #endregion

            #region Variáveis de Classe
            // String para saber a sua resposta
            string resposta = Console.ReadLine();
            // ConsoleKeyInfo para ler a sua resposta.
            ConsoleKeyInfo input;
            #endregion

            #region Ifs
            // O número escolhido é a sua resposta, preciso converter para int:
            if (int.TryParse(resposta, out int escolha))
            {
                // Switch para selecionar qual opção foi escolhida
                switch (resposta)
                {
                    // Se foi a opção 1, vamos iniciar o jogo chamando o método
                    // StartGame(); da classe Game.
                    case "1":
                        Console.Clear();
                        // static void StartGame(); para iniciar o jogo
                        Game.StartGame();
                        UserInterface.InGame();
                        break;

                    // Se foi a opção 2, vamos mostrar a sua pontuação em modo
                    // decrescente.
                    case "2":
                        WriteLines.MenuInicial_Switch_Case2();
                        // Lê o input
                        input = Console.ReadKey(true);
                        // Se o input é ENTER ou qualquer outra tecla,
                        if (input.Key == ConsoleKey.Enter ||
                            input.Key != ConsoleKey.Enter)
                        {
                            // Vamos limpar o que tinha antes e
                            Console.Clear();
                            // voltar ao menu.
                            Menu();
                        }
                        break;

                    // Se foi a opção 3, vou mostrar por quem foi desenvolvido
                    // todo este trabalho:
                    case "3":
                        WriteLines.MenuInicial_Switch_Case3();
                        // Lê o input
                        input = Console.ReadKey(true);
                        // Se o input é ENTER ou qualquer outra tecla,
                        if (input.Key == ConsoleKey.Enter ||
                            input.Key != ConsoleKey.Enter)
                        {
                            // Vamos limpar o que tinha antes e
                            Console.Clear();
                            // voltar ao menu.
                            Menu();
                        }
                        break;

                    // Se foi a opção 4, o aplicativo fecha.
                    case "4":
                        WriteLines.MenuInicial_Switch_Case4();
                        Environment.Exit(0);
                        break;
                }
            }
            // Se a resposta não for nada ou em letras,
            else if (resposta != null)
            {
                WriteLines.MenuInicial_Switch_ElseIF_01();

                // Lê o input
                input = Console.ReadKey(true);
                // Se o input é ENTER
                if (input.Key == ConsoleKey.Enter ||
                    input.Key != ConsoleKey.Enter)
                    // Vamos voltar ao menu.
                    Menu();
            }
            // Se a resposta for maior que 5 ou menor que 0,
            else if (resposta != "1" || resposta != "2" 
                || resposta != "3" || resposta != "4")
            {
                WriteLines.MenuInicial_Switch_ElseIF_02();
                // Lê o input
                input = Console.ReadKey(true);
                // Se o input é ENTER ou qualquer outra tecla,
                if (input.Key == ConsoleKey.Enter ||
                    input.Key != ConsoleKey.Enter)
                    // Vamos voltar ao menu.
                    Menu();
            }
            #endregion
        }
        #endregion
    }
}