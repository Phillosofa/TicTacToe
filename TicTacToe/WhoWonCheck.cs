using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class WhoWonCheck
    {

		public static int Check(int Spieler, string[] btns)
		{
			int winner = 0;
			string marker;

			if (Spieler != 1)
			{
				marker = "O";
			}
            else
            {
				marker = "X";
            }

			if (btns[0] == marker && btns[1] == marker && btns[2] == marker)
			{
				return Spieler;
			}
			if (btns[3] == marker && btns[4] == marker && btns[5] == marker)
			{
				return Spieler;
			}
			if (btns[6] == marker && btns[7] == marker && btns[8] == marker)
			{
				return Spieler;
			}
			if (btns[0] == marker && btns[3] == marker && btns[6] == marker)
			{
				return Spieler;
			}
			if (btns[1] == marker && btns[4] == marker && btns[7] == marker)
			{
				return Spieler;
			}
			if (btns[2] == marker && btns[5] == marker && btns[8] == marker)
			{
				return Spieler;
			}
			if (btns[0] == marker && btns[4] == marker && btns[8] == marker)
			{
				return Spieler;
			}
			return winner;
		}
	}
}
