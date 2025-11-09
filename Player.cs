using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heartsGame
{
    internal class Player
    {
        private int playerID;
        private Card[] playerCards = new Card[13];
        private int totalScore;
        private int turnScore;
        private bool bot;

        public Player(int playerNumber, bool bot)
        {
            this.bot = bot;
            this.playerID = playerNumber;
            totalScore = 0;
            turnScore = 0;
        }
    }
}
