using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    #region Tipos
    enum FoodTypes { Apple, Water }
    enum TrapTypes { Spikes, Bomb}
    enum ItemType { Common, Uncommon, Rare}
    #endregion

    #region Listas
    enum EnemyMovementList { UP, DOWN, LEFT, RIGHT }
    enum WeaponList { Sword, Staff }
    #endregion

    #region Stats
    enum EnemyStats : int { enemy1HP, enemy1AP,
        enemy2HP, enemy2AP}
    #endregion
}