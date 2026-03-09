public partial class GameSettings
{
    public AspectRatio AspectRatio { get; set; }

    public bool FullScreen { get; set; }

    public static GameSettings Default { get; } = new() { AspectRatio = AspectRatio.Widescreen };

    public const float REGULAR_TICK = 1;
    public const float PAUSE_TICK = 0;
}

public enum AspectRatio
{
    Widescreen,
    Square,
}
