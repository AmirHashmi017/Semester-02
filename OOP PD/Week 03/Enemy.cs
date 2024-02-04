using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02pd
{
    internal class Enemy
    {
        public char enemychar;
        public int eX;
        public int eY;
        public char direction;
       public Enemy(char echaracter, int ex, int ey,char direction)
        {
            this.enemychar = echaracter;
            this.eX = ex;
            this.eY = ey;
            this.direction=direction;
        }
        public void moveenemy(char[,] board)
        {
            if(direction=='l')
            {
            	board[eY,eX]=' ';
                eX--;
            board[eY, eX]=enemychar;
			}
			else if(direction=='r')
            {
            	board[eY, eX]=' ';
                eX++;
            board[eY, eX]=enemychar;
			}
        }
        public void enemystrike(char[,] board)
        {
            if(board[eY, eX +1]!=' '&&direction=='r')
            {
            direction='l';
        	}
            if(board[eY, eX -1]!=' '&&direction=='l')
            {
            direction='r';
        	}
        }
    }
}
