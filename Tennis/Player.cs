using System;
using System.Collections.Generic;
using System.Text;

namespace Tennis
{
    class Player
    {
        public int score = 0;
        public string name;
        public Player(string givenName)
        {
            name = givenName;
        }

        public void WinRound()
        {
            score++;
        }
    }
}
