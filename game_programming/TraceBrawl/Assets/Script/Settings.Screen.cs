public partial class GameSettings
{
    public void ApplyAspectRatio()
    {
        var (w, h) = AspectRatio switch
        {
            AspectRatio.Widescreen => (WIDESCREEN_WIDTH, WIDESCREEN_HEIGHT),
            AspectRatio.Square => (SQUARE_SIDE, SQUARE_SIDE),
            _ => throw new ArgumentOutOfRangeException(),
        };

        Debug.Log($"{nameof(AspectRatio)}: {w}x{h} - FullScreen: {FullScreen}");
        Screen.SetResolution(w, h, FullScreen);
    }

    const int WIDESCREEN_WIDTH = 1280;
    const int WIDESCREEN_HEIGHT = 720;
    const int SQUARE_SIDE = 800;
}
