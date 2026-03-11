public partial class Scooter : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _angle;

    void Awake()
    {
        // Debug.Log($"Spawning wall {name} @ {pos} x {size}");
        // var wall = new GameObject(name);
        // wall.transform.parent = transform;
        // wall.transform.position = pos;
        //
        // var collider = wall.AddComponent<BoxCollider2D>();
        // collider.size = size;
        // SetupTraceRenderer();
    }

    // TODO: check FixUpdate use (network ready)
    // void Update()
    // {
    //     var moveDelta = FrameMove();
    //     var steerDelta = SteerFromInput();
    //
    //     if (steerDelta != 0.0f)
    //     {
    //         transform.Rotate(0, 0, steerDelta);
    //     }
    //
    //     transform.Translate(0, moveDelta, 0);
    //
    //     PaintTracePoint();
    // }
}
