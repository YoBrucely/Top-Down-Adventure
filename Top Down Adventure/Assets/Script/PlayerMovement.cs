using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // FEATURE LIST
    // 1. use arrow keys for movement
    // 2. need a variable for speed
    // 3. we need to store the direction of our character
    // 4. need a veriable for running
    // 5. Special movements example  rolling or dashing
    // 6. mantling
    // 7. If we can climb or not

    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
