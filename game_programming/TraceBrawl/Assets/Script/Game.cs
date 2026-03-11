public partial class Game : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Starting Game");
        settings.ApplyAspectRatio();
        Time.timeScale = GameSettings.REGULAR_TICK;
    }

    void Start()
    {
        // TODO: this should happen when the player selects a start game option
        var round = StartNewRound(Camera.main);
        Scooters.Spawn(round);
    }
}
