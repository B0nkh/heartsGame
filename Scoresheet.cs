using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heartsGame
{
    internal class Scoresheet
    {
        private bool winnerBool;
        private string scoreSheet;
        private int score1, score2, score3, score4 = 0;

        //have a method that updates whether a winner has been found (Publc method) when scoresheet is updated

        public void updateScoresheet(int roundNum,int scoreP1, int scoreP2,int scoreP3, int scoreP4)
        {
            //create new line
            //        | PLAYER1 | PLAYER2 | PLAYER3 | PLAYER4
            //TOTAL   | TOTALP1 | TOTALP2 | TOTALP3 | TOTALP4
            //ROUND X | SCOREP1 | SCOREP2 | SCOREP3 | SCOREP4

            score1 = score1 + scoreP1;
            string player1 = "|\t" + score1 + "\t\t";
            score2 = score2 + scoreP2;
            string player2 = "|\t" + score2 + "\t\t";
            score3 = score3 + scoreP3;
            string player3 = "|\t" + score3 + "\t\t";
            score4 = score4 + scoreP4;
            string player4 = "|\t" + score4 + "\t\t";

            if (score1 > 50 || score2 > 50 || score3 > 50 || score4 > 50)
                winnerBool = true;

            string playerScores = player1 + player2 + player3 + player4 + "\n";
            scoreSheet ="Round " + roundNum + "\t\t" + playerScores + scoreSheet; //WRITE SCORESHEET
            displayScoresheet();
            
        }
        private void displayScoresheet()
        {
            Console.WriteLine("\t\t|\tPlayer 1\t|\tPlayer 2\t|\tPlayer 3\t|\tPlayer 4");
            Console.WriteLine(scoreSheet + "\n");
            
        }


        public bool winnerFound() //DOESNT SPECIFY WHO THE WINNER IS FFS
        {
            return winnerBool;
        }
    }
}
