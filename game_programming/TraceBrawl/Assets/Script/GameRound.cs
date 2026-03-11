public partial class GameRound
{
    public Rect WorldBounds { get; }
    public Player[] Players { get; }

    public GameRound(Camera cam, Player[] players)
    {
        Players = players;
        WorldBounds = CalculateWorldBounds(cam);
    }

    private Rect CalculateWorldBounds(Camera cam)
    {
        var height = cam.orthographicSize * 2f;
        var width = height * cam.aspect;

        var left = -width / 2f;
        var bottom = -height / 2f;

        return new Rect(x: left, y: bottom, width, height);
    }
}
