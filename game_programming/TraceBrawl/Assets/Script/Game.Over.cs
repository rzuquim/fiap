public partial class Game
{
    public void GameOver()
    {
        state = GameState.GameOver;
        Time.timeScale = GameSettings.PAUSE_TICK;
    }
}
