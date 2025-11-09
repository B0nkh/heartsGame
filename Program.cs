namespace heartsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hearts!");
            int players = 4;
            while (players == 0)
            {
                try
                {
                    Console.WriteLine("How many players will there be?");
                    players = int.Parse(Console.ReadLine());
                    if (players > 4 || players < 1)
                        throw new Exception();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number between 1 and 4 inclusive");
                    players = 0;
                }
            }
            Console.WriteLine("How many players will there be?");

            HeartsGame hearts = new HeartsGame(players);
            hearts.startGame();
        }
    }
}
