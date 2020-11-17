using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplicationNET
{
    public class Game
    {
        #region Game
        // Inicia o jogo
        public static void StartGame()
        {
            // Inicializa o Mapa
            MapManager.MapGen();

            // Inicializa o movimento do personagem
            Character.CharacterMovement();

            // Inicializa o User Interface
            UserInterface.InGame();
            Console.WriteLine();
            MenuJogo.GameMenu();

            // Inicializa os outros métodos do personagem
            Character.CharacterCollision();
            Character.CharacterLife();
            Character.CharacterTurn();

            // Inicializa as Armas
            Weapons.UseWeapons();
            Weapons.RepairWeapon();

            // Inicializa o Inimigo
            Enemy.EnemyLife();
            Enemy.EnemyMove();
            Enemy.EnemyAction();
        }

        // Inicia as configurações do ecrâ
        public static void StartTela()
        {
            // Define o tamanho do console
            Console.SetWindowSize(130, 50);
            // Define o tamanho do campo gerado procedimentalmente
            Console.SetBufferSize(Console.BufferWidth, Console.BufferHeight);
            // Define a posição do Console
            Console.SetWindowPosition(0, 0);
        }

        // Volta para o menu quando estiver em jogo
        public static void StartVoltaAoMenu()
        {
            // Inicializa o User Interface
            UserInterface.InGame();
            // Inicializa o Menu
            MenuJogo.GameMenu();

            // Inicializa o Personagem
            Character.CharacterMovement();
            Character.CharacterCollision();
            Character.CharacterLife();
            Character.CharacterTurn();
        }
        #endregion
    }
}