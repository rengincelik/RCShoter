using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FloatingJoystick joystick;
    public Rigidbody2D rb;
    public float speed;
    Vector3 moveInput;
    private void FixedUpdate() {
        moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        rb.linearVelocity=moveInput*speed;
    }
}
