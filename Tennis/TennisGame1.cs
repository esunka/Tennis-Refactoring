namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private Player player1;
        private Player player2;

        public TennisGame1(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void WonPoint(Player player)
        {
            player.WinRound();

        }
        public string ComparePlayerScore(Player player1, Player player2)
        {
            return player1.score > player2.score ? player1.name : player2.name;
        }
        public string CheckAdvantage(Player player1, Player player2)
        {
            string score = "";
            var difference = player1.score - player2.score;
            string playerWithMoreScore = ComparePlayerScore(player1, player2);
            score = "Advantage " + playerWithMoreScore;
            if (System.Math.Abs(difference) >= 2) score = "Win for " + playerWithMoreScore;

            return score;
        }

        public string ScoreEqual(int scoreParameter)
        {
            string score;
            switch (scoreParameter)
            {
                case 0:
                    score = "Love-All";
                    break;
                case 1:
                    score = "Fifteen-All";
                    break;
                case 2:
                    score = "Thirty-All";
                    break;
                default:
                    score = "Deuce";
                    break;

            }
            return score;
        }

        public string CreateScoreString(string score, Player player)
        {
            switch (player.score)
            {
                case 0:
                    score += "Love";
                    break;
                case 1:
                    score += "Fifteen";
                    break;
                case 2:
                    score += "Thirty";
                    break;
                case 3:
                    score += "Forty";
                    break;
            }
            return score;
        }
        public string GetScore(Player player1,Player player2)
        {
            string score = "";
 
            if (player1.score == player2.score)
            {
                score = ScoreEqual(player1.score);
            }
            else if (player1.score >= 4 || player2.score >= 4)
            {
                score = CheckAdvantage(player1,player2);
            }
            else
            {
                score = CreateScoreString(score, player1);
                score += "-";
                score = CreateScoreString(score, player2);      
            }
            return score;
        }
    }
}

