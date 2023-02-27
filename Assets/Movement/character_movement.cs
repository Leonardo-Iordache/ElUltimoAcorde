using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_movement : MonoBehaviour{
    // Start is called before the first frame update

    [SerializeField] private float playerSpeed = 2.0f;

    private Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        if(rb == null)
            Debug.LogError("Player is missing a Rigidbody2D component");
    }

    // Update is called once per frame
    void Update(){
        MovePlayer();
    }


    void MovePlayer(){
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var verticalInput = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(horizontalInput * playerSpeed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, verticalInput * playerSpeed);
    }
}
