

public class GameHistory
{
     public readonly int GameRating; 
    public readonly string OpponentName = "";
    public readonly bool Win;
    public readonly int GameID;
    private static int GameIDCounter = 1;

    public GameHistory(int gameRating, string opponentName, bool win)
    {
        GameRating = gameRating;
        OpponentName = opponentName;
        Win = win;

        GameID = (GameIDCounter + 1) / 2;
        GameIDCounter++;
    } 


}