using UnityEngine;
using UnityEngine.InputSystem;

public class NeMovement : MonoBehaviour
{
    Vector2 movePlayer;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myMove();
    }
    void OnMove(InputValue value)
    {
        movePlayer = value.Get<Vector2>();
        Debug.Log(movePlayer);
    }
    void myMove()
    {
        rb.linearVelocity = movePlayer;
    }
}
