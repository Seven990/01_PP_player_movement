using UnityEngine;

public class player_movement_functions : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void ExecuteMovement(Vector2 moveVector)
    {
        rb.linearVelocity = moveVector;
    }

}