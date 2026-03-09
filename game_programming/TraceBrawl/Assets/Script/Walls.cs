public partial class Walls : MonoBehaviour
{
    [SerializeField]
    private float _wallThickness = 1f;

    void Start()
    {
        Spawn();
    }
}
