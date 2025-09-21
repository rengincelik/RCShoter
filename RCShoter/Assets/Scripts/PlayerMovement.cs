using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FloatingJoystick joystick;
    public float speed;
    Vector3 moveInput;
    void Update()
    {
        moveInput = new Vector3(joystick.Horizontal, joystick.Vertical, 0.00f);
        transform.Translate(moveInput * speed * Time.deltaTime);
    }
}
