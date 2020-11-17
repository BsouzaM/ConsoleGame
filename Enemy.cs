using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    public class Enemy
    {
        #region Variáveis de Classe
        // HP do inimigo.
        int enemyHP = 100;
        // Dano do inimigo.
        int enemyAP;
        #endregion

        #region Enemy
        // Vida do inimigo
        public static void EnemyLife()
        {
            #region Variáveis Locais
            Enemy ey = new Enemy();
            #endregion
            // Se o HP do inimigo estiver menor ou igual a 0,
            if (ey.enemyHP <= 0)
                // Console: 
                Console.WriteLine("Você eliminou um inimigo.");
            else
                Console.WriteLine("Você não conseguiu eliminar o inimigo!");
        }

        // Ação do inimigo contra o player
        public static void EnemyAction()
        {
            #region Variáveis Locais
            Enemy ey = new Enemy();
            Character chr = new Character();
            #endregion

            // O dano do inimigo é tirar uma vida do player.
            ey.enemyAP = chr.charHP - 1;
            return;
        }

        // Movimentação do inimigo até o player
        public static void EnemyMove()
        {
            #region Variáveis Locais
            Enemy ey = new Enemy();
            Character chr = new Character();
            #endregion

            // Se for o turn do inimigo e não for a turn do player,
            if (chr.isCharacterTurn == false)
            {
                // Ponto em X
                int playerPosX = 7;
                // Ponto em Y
                int playerPosY = 7;

                // Posição do inimigo em X
                int monsterPosX = 0;
                // Posição do inimigo em Y
                int monsterPosY = 0;

                // Lista com os movimentos que o inimigo faz
                List<EnemyMovementList> move = new List<EnemyMovementList>();

                // Enquanto a posição X e a posição Y do inimigo não for 
                // igual a do player onde o inimigo deve chegar,
                while (monsterPosX != playerPosX || monsterPosY != playerPosY)
                {
                    // Então o inimigo está se movendo na posição X específica 
                    // para a posição X do player:
                    Console.WriteLine($"x: {monsterPosX} == {playerPosX}");
                    // Então o inimigo está se movendo na posição Y específica 
                    // para a posição Y do player:
                    Console.WriteLine($"y: {monsterPosY} == {playerPosY}");

                    // Se a posição X do inimigo é maior que o ponto X onde
                    // ele deve ir,
                    if (monsterPosX > playerPosX)
                    {
                        // Mova-se para a esquerda,
                        move.Add(EnemyMovementList.LEFT);
                        // Subtrai 1 da posição do inimigo,
                        monsterPosX--;
                        // Continua o programa.
                        continue;
                    }

                    // Se o ponto X é maior que a posição X do inimigo então,
                    if (playerPosX > monsterPosX)
                    {
                        // Mova - se para a direita,
                        move.Add(EnemyMovementList.RIGHT);
                        // Incrementa a posição do monstro uma vez.
                        monsterPosX++;
                        // Continua o programa.
                        continue;
                    }
                    // Se o ponto Y é maior que a posição Y do inimigo então,
                    if (playerPosY > monsterPosY)
                    {
                        // Mova-se para baixo,
                        move.Add(EnemyMovementList.DOWN);
                        // Incrementa a posição do monstro uma vez.
                        monsterPosY++;
                        // Continua o programa.
                        continue;
                    }
                    // Se a posição Y do inimigo é maior que o ponto Y onde
                    // ele deve ir,
                    if (monsterPosY > playerPosY)
                    {
                        // Mova-se para cima,
                        move.Add(EnemyMovementList.UP);
                        // Subtrai 1 da posição do inimigo,
                        monsterPosY--;
                        // Continua mesmo assim o programa.
                        continue;
                    }
                }
            }
        }
        #endregion
    }
}