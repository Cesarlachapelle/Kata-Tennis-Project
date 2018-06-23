using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katatennis
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Game(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }
        public string GetScore()
        {

            if (Player1.Score >= 3 && Player2.Score >= 3)
            {
                if (Player1.Score == Player2.Score)
                {
                    return "deuce";
                }
                if (Math.Abs(Player1.Score - Player2.Score) >= 2)
                {
                    return (Player1.Score > Player2.Score) ? Player1.Name + " won" : Player2.Name + " won";
                }
                return (Player1.Score > Player2.Score) ? Player1.Name + " has the advantage" : Player2.Name + " has the advantage";


            }
            return Player1.GetStoreDescription() + "-" + Player2.GetStoreDescription();
        }
    }
}
