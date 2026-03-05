[RequireComponent(typeof(LineRenderer))]
public partial class Scooter
{
    private LineRenderer lr;
    private Vector3 lastPoint;
    private readonly List<Vector3> trail = new List<Vector3>(PRE_ALLOCATE_TRACE);

    private void SetupTraceRenderer()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 0;
        lr.useWorldSpace = true;
    }

    private void PaintTracePoint()
    {
        var pos = transform.position;
        if (trail.Count == 0 ||
            Vector3.Distance(pos, lastPoint) >= MIN_POINT_DISTANCE)
        {
            AddPoint(pos);
        }
        // throw new NotImplementedException();
    }

    private const float MIN_POINT_DISTANCE = 0.2f;
    private const int PRE_ALLOCATE_TRACE = 1024;
}
