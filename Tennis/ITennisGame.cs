namespace Tennis
{
    interface ITennisGame
    {
        void WonPoint(Player player);
        string GetScore(Player player1,Player player2);
    }
}

