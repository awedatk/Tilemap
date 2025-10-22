using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    Vector2 movementPlayer;//(1)
    Rigidbody2D rb;//(2)
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//(4)
    }

    // Update is called once per frame
    void Update()
    {
        myMove();
    }
    void OnMove(InputValue value)//(3)
    {
        movementPlayer = value.Get<Vector2>();//(5)
        Debug.Log(movementPlayer);
    }
    void myMove()//(6)
    {
        rb.linearVelocity = movementPlayer;
    }
}
