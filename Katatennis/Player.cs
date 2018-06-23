using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katatennis
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; private set; }

        public Player(string name)
        {
            this.Name = name;

        }

        public void WinPoint()
        {
            this.Score++;
        }

        public string GetStoreDescription()
        {
            switch (Score)
            {
                case 3:
                    return "forty";
                case 2:
                    return "thirty";
                case 1:
                    return "fifteen";
                case 0:
                    return "love";
                default:
                    return "0";
            }
        }
    }
}
