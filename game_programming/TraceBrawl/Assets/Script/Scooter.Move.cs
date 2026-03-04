using UnityEngine;

public partial class Scooter
{
    private float FrameMove()
    {
        var deltaMove = BASE_SPEED * Time.deltaTime;
        return deltaMove;
    }

    private const float BASE_SPEED = 5;
}
