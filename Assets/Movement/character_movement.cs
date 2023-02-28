using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_movement : MonoBehaviour{
    // Start is called before the first frame update

    public float playerSpeed = 2.0f;

    Vector2 movement;
    Vector2 mousePos;
    public Rigidbody2D player_rb;
    public GameObject firePoint;
    public Camera cam;

    void Start() {
        firePoint = GameObject.Find("firePoint");    
    }

    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 
    }

    void FixedUpdate() {
        player_rb.MovePosition(player_rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        Vector2 firePoint_Direction = mousePos - player_rb.position;
        float angle = Mathf.Atan2(firePoint_Direction.y, firePoint_Direction.x) * Mathf.Rad2Deg - 90f;

        firePoint.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }    
}




