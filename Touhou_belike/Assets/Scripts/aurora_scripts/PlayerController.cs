using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;

    Vector2 moveAmount;

    public Rigidbody2D rb;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        // Input
        moveAmount.x = Input.GetAxisRaw("Horizontal"); 
        moveAmount.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + moveAmount * movementSpeed * Time.fixedDeltaTime);
    }
}
