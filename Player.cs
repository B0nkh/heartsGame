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

        public Player(int playerNumber)
        {
            this.playerID = playerNumber;
            totalScore = 0;
            turnScore = 0;
        }
    }
}
