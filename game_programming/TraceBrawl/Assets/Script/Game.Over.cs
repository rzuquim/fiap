public partial class Game : MonoBehaviour
{
    public void GameOver()
    {
        state = GameState.GameOver;
        Time.timeScale = GameSettings.PAUSE_TICK;
    }
}
