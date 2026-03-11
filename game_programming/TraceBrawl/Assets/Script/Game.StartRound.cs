public partial class Game
{
    public GameRound? CurrentRound { get; private set; }

    private GameRound StartNewRound(Camera cam)
    {
        if (CurrentRound is not null)
        {
            throw new InvalidOperationException(
                "Trying to start a new round without ending the current one."
            );
        }

        Debug.Log($"Starting a {nameof(GameRound)}");
        return CurrentRound = new GameRound(cam, TempSinglePlayer());
    }

    private Player[] TempSinglePlayer()
    {
        return new[] { new Player(name: "Zuquim", color: Color.orangeRed) };
    }
}
