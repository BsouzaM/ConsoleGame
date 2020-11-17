using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    public class Weapons
    {
        #region Variáveis Globais
        // Especifica o weaponID como um array para a quantidade de IDs para
        // armas.
        public int[,] WeaponID { get; set; }
        // Boolean para: A arma está reparada?
        bool isWeaponRepaired;
        // O player quer reparar a arma?
        ConsoleKeyInfo playerWillRepair;
        #endregion

        #region Armas
        // "Player decide usar a arma"
        public static void UseWeapons()
        {
            #region Variáveis Locais
            Weapons wp = new Weapons();
            #endregion

            // Se a arma não foi reparada,
            if (wp.isWeaponRepaired == false)
                // Vamos repará-la.
                RepairWeapon();

            if (wp.isWeaponRepaired == true)
                Console.WriteLine("A arma foi reparada!");
        }

        // "Player decide reparar uma arma" (Template para usar em outros casos)
        public static void RepairWeapon()
        {
            #region Variáveis Locais
            Weapons wp = new Weapons();

            #endregion

            // Console para verificar se o player quer ou não reparar a arma:
            Console.WriteLine("Você deseja reparar a arma? Y/N");
            // Lê o input
            wp.playerWillRepair = Console.ReadKey();
            // Se a tecla for: 
            if (wp.playerWillRepair.Key == ConsoleKey.Y)
                // A arma vai se reparar.
                wp.isWeaponRepaired = true;
            // Senão,
            else if (wp.playerWillRepair.Key == ConsoleKey.N)
                wp.isWeaponRepaired = false;
            // Se a arma estiver reparada,
            if (wp.isWeaponRepaired == true)
            {
                UseWeapons();
                return;
            }
            else
                Game.StartGame();
        }
        #endregion
    }
}