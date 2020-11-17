using System;
using System.Collections.Generic;

namespace ConsoleApplicationNET
{
    public class Character
    {
        #region Variáveis Globais

        // "Game object" do player
        public char charGameObject = '⨀';
        // "Game object" das paredes
        public char wallGameObject = '#';

        // HP do personagem
        public int charHP = 100;
        // Int sempre verdadeiro para o do-while do CharacterMovement();
        int gameOver = 0;
        // Axis X do personagem
        int leftAndRight = 1;
        // Axis Y do personagem
        int upAndDown = 1;
        // Peso do inventário
        public int charWeight = 35;

        // O player está morto?
        bool isCharacterDead;
        // É a vez do player jogar?
        public bool isCharacterTurn;
        // A turn acabou?
        public bool isTurnOver = false;

        // IEnumerable para definir a quantidade de turns para o foreach.
        static IEnumerable<int> Turns { get; set; }
        #endregion

        #region Character
        // Vida do personagem
        public static void CharacterLife()
        {
            #region Variável Local 
            Character chr = new Character();
            #endregion

            // Se o personagem morre
            if (chr.charHP <= 0 && chr.isCharacterDead == true
            || chr.charHP <= 0 || chr.isCharacterDead == true)
                // console:
                Console.WriteLine("O personagem está morto.");
            // Senão...
            else
            {
                // Enquanto o HP do personagem estiver maior ou igual a 1 
                while (chr.charHP >= 1)
                {
                    GameTurns trn = new GameTurns();

                    GameTurns.DecreaseTurns();
                    if (chr.isCharacterTurn == true)
                        CharacterTurn();

                    if (chr.charHP <= 0)
                        chr.isCharacterDead = true;

                }
            }
        }

        // Turn do personagem
        public static void CharacterTurn()
        {
            #region Variável Local 
            Character chr = new Character();
            #endregion

            // Se não for a vez do jogador (quando isCharacterTurn == false)
            // ou quando a turn acabou, então:
            if (chr.isCharacterTurn == false || chr.isTurnOver == true)
                // Console:
                Console.WriteLine("Agora não é a sua turn!");
            else if (chr.isTurnOver == true)
            {
                Console.WriteLine("A turn acabou e você perdeu uma vida.");
                // O player perde uma vida.
                CharacterDamage();
            }
            return;
        }

        // Movimento do personagem
        public static void CharacterMovement()
        {
            #region Variável Local 
            Character chr = new Character();
            MenuJogo mj = new MenuJogo();
            ConsoleKeyInfo input;
            WriteLines.Character_InputESC();
            WriteLines.Character_InputQ();
            #endregion

            do
            {
                input = Console.ReadKey(true);
                Console.SetCursorPosition(chr.leftAndRight, chr.upAndDown);
                Console.WriteLine(" ");
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:
                        chr.leftAndRight++;
                        break;

                    case ConsoleKey.LeftArrow:
                        chr.leftAndRight--;
                        break;

                    case ConsoleKey.DownArrow:
                        chr.upAndDown++;
                        break;

                    case ConsoleKey.UpArrow:
                        chr.upAndDown--;
                        break;

                    case ConsoleKey.Escape:
                        WriteLines.Character_Movement_Space();
                        MenuJogo.GameMenu();
                        break;

                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
                Console.SetCursorPosition(chr.leftAndRight, chr.upAndDown);
                Console.Write(chr.charGameObject);
            }
            while (chr.gameOver == 0);

            if (chr.gameOver == 1)
                Console.Beep();
        }

        // Colisão do personagem com a parede
        public static void CharacterCollision()
        {
            #region Variável Local 
            Character chr = new Character();
            #endregion

            // Colisão com a parede (#)
            if (chr.charGameObject != /* estiver em cima de */ chr.wallGameObject)
                chr.charGameObject = 'S';
            // Colisão com o Exit (E)
            else if (chr.wallGameObject == /* estiver em cima de */ 'E')
            {
                // Se ele vai colidir com um "E", a fase muda
            }
        }

        // Dano no personagem
        public static void CharacterDamage()
        {
            #region Variável Local 
            Character chr = new Character();
            #endregion

            // O player perde uma vida.
            chr.charHP = chr.charHP - 1;
            return;
        }
        #endregion
    }
}