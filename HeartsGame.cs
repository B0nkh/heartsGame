using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace heartsGame
{
    public class HeartsGame
    {
        public string[] decks = { "Cliubs", "Diamonds", "Spades", "Hearts" };
        public string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        private int playerCount;
        private int turnCount = 1;
        enum TurnType
        {
            LEFT,
            FORWARD,
            RIGHT,
            NONE
        }
        private TurnType turn;

        public HeartsGame(int players)
        {
            this.playerCount = players;
        }
        public void startGame()
        {
            Console.WriteLine("You've started the game with {0} players", playerCount);
            //create players
            createPlayers();

            //create deck
            //createDeck();
            Scoresheet scoresheet = new Scoresheet();
            while(!scoresheet.winnerFound())
            {
                //DO ALL THIS
                //dealing
                for (int playerDeck = 1; playerDeck < playerCount + 1; playerDeck++)
                {
                    //deal cards to player
                }

                //calculate type
                switch ((turnCount - 1) % 4)
                {
                    case 0:
                        turn = TurnType.LEFT; 
                        break;
                    case 1:
                        turn = TurnType.FORWARD;
                        break;
                    case 2:
                        turn = TurnType.RIGHT;
                        break;
                    case 3:
                        turn = TurnType.NONE;
                        break;
                }
            }

            Console.WriteLine("Winner Found!");

        }
        private void createPlayers()
        {
            for (int playerID = 1; playerID < 5; playerID++)
            {

            }
        }
        private void beginTurn()
        {

        }

        private void createDeck() //TODO
        {

        }
    }
}
