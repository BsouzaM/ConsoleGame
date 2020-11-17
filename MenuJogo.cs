using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    public class MenuJogo
    {
        #region GameMenu
        public static void GameMenu()
        {
            #region Variáveis
            // Input da resposta para a seleção no menu do jogo
            ConsoleKeyInfo input;
            WriteLines.MenuJogo_GameMenu();

            // Lê o input
            input = Console.ReadKey(true);
            #endregion

            #region Listas
            // Lista com os stats dos inimigos
            List<EnemyStats> enemy = new List<EnemyStats>();
            // Carrega as listas de armas.
            List<WeaponList> arma = new List<WeaponList>();
            #endregion

            #region Input F
            // Se o input é F,
            if (input.Key == ConsoleKey.F)
            {
                WriteLines.MenuJogo_InputF();

                // Lê o input e não mostra qual tecla foi pressionada
                input = Console.ReadKey(true);

                // Se foi pressionado 0, volta para o menu
                if (input.Key == ConsoleKey.NumPad0
                    || input.Key == ConsoleKey.D0)
                {
                    Console.Clear();
                    Game.StartGame();
                }
                // Se foi pressionado 1, você ataca o primeiro inimigo
                else if (input.Key == ConsoleKey.NumPad1
                    || input.Key == ConsoleKey.D1)
                {
                    WriteLines.MenuJogo_InputF_Numpad1();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se foi pressionado 2, você ataca o segundo inimigo
                else if (input.Key == ConsoleKey.NumPad2
                    || input.Key == ConsoleKey.D2)
                {
                    WriteLines.MenuJogo_InputF_Numpad2();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                else
                {
                    WriteLines.MenuJogo_InputF_Numpad2_Else();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
            }
            #endregion

            #region Input E
            // Se a tecla E for pressionada,
            if (input.Key == ConsoleKey.E)
            {
                WriteLines.MenuJogo_InputE();

                // Lê o input
                input = Console.ReadKey(true);

                // Se a resposta for 0, volta para o menu
                if (input.Key == ConsoleKey.NumPad0
                    || input.Key == ConsoleKey.D0)
                {
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 1, você joga fora sua staff
                else if (input.Key == ConsoleKey.NumPad1
                    || input.Key == ConsoleKey.D1)
                {
                    WriteLines.MenuJogo_InputE_Numpad1();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 2, você joga fora sua sword.
                else if (input.Key == ConsoleKey.NumPad2
                    || input.Key == ConsoleKey.D2)
                {
                    WriteLines.MenuJogo_InputE_Numpad2();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                else
                {
                    WriteLines.MenuJogo_InputE_Numpad2_Else();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                return;
            }
            #endregion

            #region Input U
            // Se o input é U,
            if (input.Key == ConsoleKey.U)
            {
                WriteLines.MenuJogo_InputU();
                input = Console.ReadKey(true);
                // Se a resposta for 0, volta para o menu
                if (input.Key == ConsoleKey.NumPad0
                    || input.Key == ConsoleKey.D0)
                {
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 1, você usa sua staff
                else if (input.Key == ConsoleKey.NumPad1
                    || input.Key == ConsoleKey.D1)
                {
                    WriteLines.MenuJogo_InputU_Numpad1();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 2, você usa sua sword.
                else if (input.Key == ConsoleKey.NumPad2
                    || input.Key == ConsoleKey.D2)
                {
                    WriteLines.MenuJogo_InputU_Numpad2();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                else
                {
                    WriteLines.MenuJogo_InputU_Numpad2_Else();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                return;

            }
            #endregion

            #region Input D
            // Se o input é D,
            if (input.Key == ConsoleKey.D)
            {
                WriteLines.MenuJogo_InputD();
                input = Console.ReadKey(true);
                // Se a resposta for 0, volta para o menu
                if (input.Key == ConsoleKey.NumPad0
                    || input.Key == ConsoleKey.D0)
                {
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 1, você usa sua staff
                else if (input.Key == ConsoleKey.NumPad1)
                {
                    WriteLines.MenuJogo_InputD_Numpad1();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 2, você usa sua sword.
                else if (input.Key == ConsoleKey.NumPad2
                    || input.Key == ConsoleKey.D2)
                {
                    WriteLines.MenuJogo_InputD_Numpad2();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                else
                {
                    WriteLines.MenuJogo_InputD_Numpad2_Else();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                return;
            }


            #endregion

            #region Input L
            // Se o input é L,
            if (input.Key == ConsoleKey.L)
            {
                WriteLines.MenuJogo_InputL();
                input = Console.ReadKey(true);
                // Se a resposta for 0, volta para o menu
                if (input.Key == ConsoleKey.NumPad0
                    || input.Key == ConsoleKey.D0)
                {
                    Game.StartGame();
                }
                // Se a resposta for 1, você vê a descrição das Spikes
                else if (input.Key == ConsoleKey.NumPad1)
                {
                    WriteLines.MenuJogo_InputL_Numpad1();
                    Console.ReadKey(true);
                    Game.StartGame();
                }
                // Se a resposta for 2, você vê a descrição da Bomb
                else if (input.Key == ConsoleKey.NumPad2
                    || input.Key == ConsoleKey.D2)
                {
                    WriteLines.MenuJogo_InputL_Numpad2();
                    Console.ReadKey(true);
                    Game.StartGame();
                }
                // Se a resposta for 3, você vê a descrição das Water
                else if (input.Key == ConsoleKey.NumPad3
                    || input.Key == ConsoleKey.D3)
                {
                    WriteLines.MenuJogo_InputL_Numpad3();
                    Console.ReadKey(true);
                    Game.StartGame();
                }
                // Se a resposta for 4, você vê a descrição das Apple
                else if (input.Key == ConsoleKey.NumPad4
                    || input.Key == ConsoleKey.D4)
                {
                    WriteLines.MenuJogo_InputL_Numpad4();
                    Console.ReadKey(true);
                    Game.StartGame();
                }
                // Se a resposta for 5, você vê a descrição das Staff
                else if (input.Key == ConsoleKey.NumPad5
                    || input.Key == ConsoleKey.D5)
                {
                    WriteLines.MenuJogo_InputL_Numpad5();
                    Console.ReadKey(true);
                    Game.StartGame();
                }
                // Se a resposta for 6, você vê a descrição das Sword
                else if (input.Key == ConsoleKey.NumPad6
                    || input.Key == ConsoleKey.D6)
                {
                    WriteLines.MenuJogo_InputL_Numpad6();
                    Console.ReadKey(true);
                    Game.StartGame();
                }
                else
                {
                    WriteLines.MenuJogo_InputL_Numpad6_Else();
                    Console.ReadKey(true);
                    Game.StartGame();
                }
                return;
            }
            #endregion

            #region Input H
            // Se o input é H,
            if (input.Key == ConsoleKey.H)
            {
                WriteLines.MenuJogo_InputH();
                input = Console.ReadKey(true);
                // Se a resposta for 0, volta para o menu
                if (input.Key == ConsoleKey.NumPad0
                    || input.Key == ConsoleKey.D0)
                {
                    Console.Clear();
                    Game.StartVoltaAoMenu();
                }
                // Se a resposta for 1, você vê a informação das Spikes
                else if (input.Key == ConsoleKey.NumPad1)
                {
                    WriteLines.MenuJogo_InputH_Numpad1();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 2, você vê a informação da Bomb
                else if (input.Key == ConsoleKey.NumPad2
                    || input.Key == ConsoleKey.D2)
                {
                    WriteLines.MenuJogo_InputH_Numpad2();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 3, você vê a informação da Water
                else if (input.Key == ConsoleKey.NumPad3
                    || input.Key == ConsoleKey.D3)
                {
                    WriteLines.MenuJogo_InputH_Numpad3();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 4, você vê a informação da Apple
                else if (input.Key == ConsoleKey.NumPad4
                    || input.Key == ConsoleKey.D4)
                {
                    WriteLines.MenuJogo_InputH_Numpad4();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 5, você vê a informação da Staff
                else if (input.Key == ConsoleKey.NumPad5
                    || input.Key == ConsoleKey.D5)
                {
                    WriteLines.MenuJogo_InputH_Numpad5();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                // Se a resposta for 6, você vê a informação da Sword
                else if (input.Key == ConsoleKey.NumPad6
                    || input.Key == ConsoleKey.D6)
                {
                    WriteLines.MenuJogo_InputH_Numpad6();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                else
                {
                    WriteLines.MenuJogo_InputH_Numpad6_Else();
                    Console.ReadKey(true);
                    Console.Clear();
                    Game.StartGame();
                }
                return;
            }
            #endregion

            #region Input Q
            // E se o input é Q,
            if (input.Key == ConsoleKey.Q)
            {
                Console.Clear();
                Environment.Exit(0);
            }
            return;
            #endregion
        }
        #endregion
    }
}