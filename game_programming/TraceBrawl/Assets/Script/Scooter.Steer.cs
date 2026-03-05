using UnityEngine.InputSystem;

public partial class Scooter
{
    private float SteerFromInput()
    {
        var kb = Keyboard.current;
        var steer =
            kb.aKey.isPressed ? STEER_HANDLING * Time.deltaTime :
            kb.dKey.isPressed ? -STEER_HANDLING * Time.deltaTime :
            0f;
        Debug.Log(steer);
        return steer;
    }

    private const float STEER_HANDLING = 200;
}
