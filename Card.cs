using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heartsGame
{
    public class Card
    {
        private string deck;
        private string name;
        private int player;
        private int pointValue;

        public Card(string newDeck, string newName, int playerAssigned)
        {
            pointValue = 0;
            //assigning known values
            this.deck = newDeck;
            this.name = newName;
            this.player = playerAssigned;

            //checking for spade queen and heart
            if ((deck == "Spades") && (name == "Queen"))
                pointValue = 13;
            if (deck == "Hearts")
                pointValue = 1;
        }

        //GETTERS
        string getDeck()
        {
            return deck;
        }
        string getName()
        {
            return name;
        }
        int getPointValue()
        {
            return pointValue;
        }

        int getPlayer()
        {
            return player;
        }
    }
}
