public partial class Game : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Starting Game");
        settings.ApplyAspectRatio();
        Time.timeScale = GameSettings.REGULAR_TICK;
    }
}
