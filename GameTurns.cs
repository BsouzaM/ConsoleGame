using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationNET
{
    public class GameTurns
    {
        #region Turns
        public static void DecreaseTurns()
        {
            Character chr = new Character();
            int numberOfTurns;

            // Diminui a vida do player a cada turn;
            if (chr.isCharacterTurn == false)
            {
                chr.isTurnOver = true;
                numberOfTurns = chr.charHP - 1;
            }
        }
        #endregion
    }
}