using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApplicationNET
{
    public class WriteLines
    {
        #region MenuJogo()
        // Menu dentro do jogo
        public static void MenuJogo_GameMenu()
        {
            Console.WriteLine("O que você quer fazer agora?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("F para atacar um inimigo no tile atual.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("E para apanhar um item no tile atual.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("U para usar um item.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("D para deixar cair um item no tile atual.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("L para mostrar descrição dos itens.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("H para mostrar informação acerca dos itens " +
                "e armadilhas disponíveis no jogo.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Q para terminar o jogo.");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.Write("Eu seleciono a opção: ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
        }

        #region Tecla F
        // Tecla F
        public static void MenuJogo_InputF()
        {
            // Abre o menu
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione um inimigo para atacar");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine($"1. Enemy (HP={EnemyStats.enemy1HP}" +
                $"|AP={EnemyStats.enemy1AP})");
            Console.WriteLine($"2. Enemy (HP={EnemyStats.enemy2HP}" +
                $"|AP={EnemyStats.enemy2AP})");
        }
        // Tecla F, Numpad 1
        public static void MenuJogo_InputF_Numpad1()
        {
            Console.WriteLine();
            Console.WriteLine("Você atacou o primeiro inimigo\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla F, Numpad 2
        public static void MenuJogo_InputF_Numpad2()
        {
            Console.WriteLine();
            Console.WriteLine("Você atacou o segundo inimigo\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla F, Numpad 1, Else(){}
        public static void MenuJogo_InputF_Numpad2_Else()
        {
            Console.WriteLine("Só há três opções!\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        #endregion

        #region Tecla E
        // Tecla E
        public static void MenuJogo_InputE()
        {
            // Abre o menu
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione um item para pegar: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine($"1. {WeaponList.Staff}");
            Console.WriteLine($"2. {WeaponList.Sword}");
            Console.WriteLine();
        }
        // Tecla E, Numpad 1
        public static void MenuJogo_InputE_Numpad1()
        {
            Console.WriteLine();
            Console.WriteLine($"Você pegou uma {WeaponList.Staff}.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla E, Numpad 2
        public static void MenuJogo_InputE_Numpad2()
        {
            Console.WriteLine();
            Console.WriteLine($"Você pegou uma {WeaponList.Sword}.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla E, Numpad 2, Else(){}
        public static void MenuJogo_InputE_Numpad2_Else()
        {
            Console.WriteLine("Só há três opções!\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        #endregion

        #region Tecla U
        // Tecla U
        public static void MenuJogo_InputU()
        {
            // Abre o menu
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione um item para usar: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine($"1. {FoodTypes.Apple}");
            Console.WriteLine($"2. {FoodTypes.Water}");
            Console.WriteLine();
        }
        // Tecla U, Numpad 1
        public static void MenuJogo_InputU_Numpad1()
        {
            Console.WriteLine($"Você comeu a sua {FoodTypes.Apple}.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla U, Numpad 2
        public static void MenuJogo_InputU_Numpad2()
        {
            Console.WriteLine($"Você bebeu a sua {FoodTypes.Water}.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla U, Numpad 2, Else(){}
        public static void MenuJogo_InputU_Numpad2_Else()
        {
            Console.WriteLine("Só há três opções!");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        #endregion

        #region Tecla D
        // Tecla D
        public static void MenuJogo_InputD()
        {
            // Abre o menu
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione um item para jogar no chão: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine($"1. {TrapTypes.Spikes}");
            Console.WriteLine($"2. {TrapTypes.Bomb}");
            Console.WriteLine();
        }
        // Tecla D, Numpad 1
        public static void MenuJogo_InputD_Numpad1()
        {
            Console.WriteLine($"Você jogou fora o item: {TrapTypes.Spikes}.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla D, Numpad 2
        public static void MenuJogo_InputD_Numpad2()
        {
            Console.WriteLine($"Você jogou fora o item: {TrapTypes.Bomb}.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla D, Numpad 2, Else(){}
        public static void MenuJogo_InputD_Numpad2_Else()
        {
            Console.WriteLine("Só há três opções!");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        #endregion

        #region Tecla L
        // Tecla L
        public static void MenuJogo_InputL()
        {
            // Abre o menu
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione um objeto para ver sua descrição: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine($"1. Ver {TrapTypes.Spikes}");
            Console.WriteLine($"2. Ver {TrapTypes.Bomb}");
            Console.WriteLine($"3. Ver {FoodTypes.Water}");
            Console.WriteLine($"4. Ver {FoodTypes.Apple}");
            Console.WriteLine($"5. Ver {WeaponList.Staff}");
            Console.WriteLine($"6. Ver {WeaponList.Sword}");
            Console.WriteLine();
        }
        // Tecla L, Numpad 1
        public static void MenuJogo_InputL_Numpad1()
        {
            Console.WriteLine($"Armadilha: {TrapTypes.Spikes}");
            Console.WriteLine($"Descrição: Por mais que sejam espigas, " +
                $"ainda sim só tiram pouca vida do personagem.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla L, Numpad 2
        public static void MenuJogo_InputL_Numpad2()
        {
            Console.WriteLine($"Armadilha: {TrapTypes.Bomb}");
            Console.WriteLine($"Descrição: É uma bomba, é melhor se manter " +
                $"afastado dela! Podem matar o personagem.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla L, Numpad 3
        public static void MenuJogo_InputL_Numpad3()
        {
            Console.WriteLine($"Comida: {FoodTypes.Apple}");
            Console.WriteLine($"Descrição: Uma maçã, uma linda maçã. " +
                $"Cura parte da vida do personagem.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla L, Numpad 4
        public static void MenuJogo_InputL_Numpad4()
        {
            Console.WriteLine($"Bebida: {FoodTypes.Water}");
            Console.WriteLine($"Descrição: Nada melhor que uma água, não?" +
                $"Hidrata o seu personagem e ele cura toda sua vida.");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla L, Numpad 5
        public static void MenuJogo_InputL_Numpad5()
        {
            Console.WriteLine($"Arma: {WeaponList.Staff}");
            Console.WriteLine($"Descrição: Minha staff... uma relíquia. Sim!" +
                $"Mas é MINHA!");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla L, Numpad 6
        public static void MenuJogo_InputL_Numpad6()
        {
            Console.WriteLine($"Arma: {WeaponList.Sword}");
            Console.WriteLine($"Descrição: A... cruzada... " +
                $"alimentou... minha raiva...");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla L, Numpad 6, Else(){}
        public static void MenuJogo_InputL_Numpad6_Else()
        {
            Console.WriteLine("Só há seis opções!");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        #endregion

        #region Tecla H
        // Tecla H
        public static void MenuJogo_InputH()
        {
            // Abre o menu
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Selecione um objeto para ver suas informações: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("0. Voltar");
            Console.WriteLine($"1. Ver {TrapTypes.Spikes}");
            Console.WriteLine($"2. Ver {TrapTypes.Bomb}");
            Console.WriteLine($"3. Ver {FoodTypes.Water}");
            Console.WriteLine($"4. Ver {FoodTypes.Apple}");
            Console.WriteLine($"5. Ver {WeaponList.Staff}");
            Console.WriteLine($"6. Ver {WeaponList.Sword}");
            Console.WriteLine();
        }
        // Tecla H, Numpad 1
        public static void MenuJogo_InputH_Numpad1()
        {
            Console.WriteLine($"Armadilha: {TrapTypes.Spikes}");
            Console.WriteLine($"Raridade: {ItemType.Common}");
            Console.WriteLine("Dano no personagem: Baixo\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla H, Numpad 2
        public static void MenuJogo_InputH_Numpad2()
        {
            Console.WriteLine($"Armadilha: {TrapTypes.Bomb}");
            Console.WriteLine($"Raridade: {ItemType.Common}");
            Console.WriteLine("Dano no personagem: Alto\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla H, Numpad 3
        public static void MenuJogo_InputH_Numpad3()
        {
            Console.WriteLine($"Comida: {FoodTypes.Apple}");
            Console.WriteLine($"Raridade: {ItemType.Uncommon}");
            Console.WriteLine("Peso no inventário: 1kg\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla H, Numpad 4
        public static void MenuJogo_InputH_Numpad4()
        {
            Console.WriteLine($"Bebida: {FoodTypes.Water}");
            Console.WriteLine($"Raridade: {ItemType.Uncommon}");
            Console.WriteLine("Peso no inventário: 2kg\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla H, Numpad 5
        public static void MenuJogo_InputH_Numpad5()
        {
            Console.WriteLine($"Arma: {WeaponList.Staff}");
            Console.WriteLine($"Raridade: {ItemType.Rare}");
            Console.WriteLine("Peso no inventário: 30kg\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla H, Numpad 6
        public static void MenuJogo_InputH_Numpad6()
        {
            Console.WriteLine($"Arma: {WeaponList.Sword}");
            Console.WriteLine($"Raridade: {ItemType.Rare}");
            Console.WriteLine("Peso no inventário: 50kg\n");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        // Tecla H, Numpad 6, Else(){}
        public static void MenuJogo_InputH_Numpad6_Else()
        {
            Console.WriteLine("Só há seis opções!");
            Console.WriteLine("Pressione qualquer tecla para voltar.");
        }
        #endregion

        #endregion

        #region Game()
        // Texto para começar o jogo
        public static void Game_StartGame()
        {
            Console.WriteLine("\nBem vindo ao Roguelike Stress Game!");
            Console.WriteLine("Pressione a seta para baixo para começar!");
            Console.WriteLine();
        }
        #endregion

        #region MenuInicial()
        // Bloco de texto para o menu inicial
        public static void MenuInicial_Menu()
        {
            Console.WriteLine("Por favor, escolha um número: ");
            Console.WriteLine("--------------------");
            Console.WriteLine("[1] Novo jogo");
            Console.WriteLine("[2] Pontuação Máxima");
            Console.WriteLine("[3] Créditos");
            Console.WriteLine("[4] Sair do jogo");
            Console.WriteLine("--------------------");
            Console.Write("Eu escolho a opção: ");
        }
        // Opção 1 do menu inicial
        public static void MenuInicial_Switch_Case1()
        {
            Console.WriteLine("[1] Novo jogo");
            Console.WriteLine("Pressione alguma tecla para iniciar o jogo.");
        }
        // Opção 2 do menu inicial
        public static void MenuInicial_Switch_Case2()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("[2] Pontuação Máxima.\n");
            // Mostra a pontuação que o jogador definiu nas perguntas
            HighScore.MostrarPontuacao();
            Console.WriteLine("Pressione ENTER ou qualquer outra " +
                "tecla para voltar ao menu principal.\n");
        }
        // Opção 3 do menu inicial
        public static void MenuInicial_Switch_Case3()
        {
            Console.WriteLine("\n[3] Créditos\n");
            Console.WriteLine("Trabalho desenvolvido por Bernardo " +
                "Medeiros, Nº 21809327.");
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER ou qualquer outra " +
                "tecla para voltar ao menu principal.\n");
        }
        // Opção 4 do menu inicial
        public static void MenuInicial_Switch_Case4()
        {
            Console.WriteLine("[4] Sair do jogo\n");
            Console.WriteLine("Até mais...");
        }
        // Se não houver respostas no menu inicial:
        public static void MenuInicial_Switch_ElseIF_01()
        {
            Console.WriteLine("O campo de resposta deve ser preenchido " +
            "com algum número!");
            Console.WriteLine("Pressione ENTER ou qualquer outra " +
                        "tecla para voltar ao menu principal.\n");
        }
        // Se a resposta for maior que 4 ou menor que 1: 
        public static void MenuInicial_Switch_ElseIF_02()
        {
            // Console:
            Console.WriteLine("A resposta deve ser apenas de 1 a 4!");
            Console.WriteLine("Pressione ENTER ou qualquer outra " +
                        "tecla para voltar ao menu principal.\n");
        }
        #endregion

        #region HighScore()
        // Pontuação do jogo
        public static void HighScore_MostrarPontuacao()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("A pontuação máxima do jogo foi: ");
        }
        #endregion

        #region UserInterface()
        // Mostra ao utilizador o User Interface em jogo: 
        public static void UserInterface_InGame()
        {
            Character chr = new Character();
            Weapons wp = new Weapons();

            Console.WriteLine($"Character HP: {chr.charHP}");
            Console.WriteLine($"Weapon: {wp.WeaponID}");
            Console.WriteLine($"Character Weight: {chr.charWeight}");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("↖ ↑ ↗  (F) Attack Enemy   (E) Pick up item");
            Console.WriteLine("←    →   (L) Look around    (H) Help");
            Console.WriteLine("↙ ↓ ↘  (S)Save game       (Q) Quit game");
            Console.WriteLine("         (U) Use item       (D) Drop item");

        }
        #endregion

        #region Program()
        // Perguntas ao utilizador sobre o Main(string[] args);
        public static void Program_Args_Question()
        {
            Console.WriteLine("Por favor! Digite um argumento para args[0]: ");
            string resposta = Console.ReadLine();
            if (resposta == "Menu")
            {
                MenuInicial.Menu();
                MapManager.MapGen();
            }
            else
            {
                Console.WriteLine("Seu argumento é inválido!\nArgumentos válidos: Menu\n");
                Program_Args_Question();
            }
            Console.Clear();
        }
        #endregion

        #region Character()
        public static void Character_InputESC()
        {
            Console.WriteLine("Pressione ESC para abrir o menu.");
            Console.WriteLine();
        }
        public static void Character_InputQ()
        {
            Console.WriteLine("Pressione Q para sair do jogo a qualquer hora.");
            Console.WriteLine();
        }

        // Linhas para abrir o menu corretamente
        public static void Character_Movement_Space()
        {
            for (int i = 0; i < 28; i++)
                Console.WriteLine();
        }
        #endregion
    }
}