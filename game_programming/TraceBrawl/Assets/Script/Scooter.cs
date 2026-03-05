public partial class Scooter : MonoBehaviour
{
    void Awake()
    {
        SetupTraceRenderer();
    }

    // TODO: check FixUpdate use (network ready)
    void Update()
    {
        var moveDelta = FrameMove();
        var steerDelta = SteerFromInput();

        if (steerDelta != 0.0f)
        {
            transform.Rotate(0, 0, steerDelta);
        }

        transform.Translate(0, moveDelta, 0);

        PaintTracePoint();
    }
}
