﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigDiceGame
{
    class player
    {
        string PlayerName;
        int PlayerScore;

        public player(string PlayerName)
        {
            this.PlayerName = PlayerName;
            this.PlayerScore = 0;
        }

        public void setPlayerName(string PlayerName)
        {
            this.PlayerName = PlayerName;
        }
        public string getPlayerName()
        {
            return this.PlayerName;
        }
        public void setPlayerScore(int pointsScored)
        {
            this.PlayerScore = this.PlayerScore + pointsScored;
        }
        public int getPlayerScore()
        {
            return this.PlayerScore;
        }
    }
}
