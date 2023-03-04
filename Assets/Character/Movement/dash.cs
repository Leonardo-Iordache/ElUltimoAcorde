using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour{
    
    public Rigidbody2D rb;
    public int dashForce = 5;

    private bool hasDash = true;
    private int dashCooldown = 80;
    private void FixedUpdate() {
        if(dashCooldown == 0){
            hasDash = true;
        }
        else{
            dashCooldown--;
        }
        
        rb.velocity = Vector2.zero;

        if(Input.GetKey(KeyCode.Space) && hasDash){
            Vector2 mouseDirection = (Input.mousePosition - new Vector3(Screen.width / 2, Screen.height / 2));
            rb.AddForce(mouseDirection * dashForce * Time.fixedDeltaTime);
            hasDash = false;
            dashCooldown = 80;
        }
    }
}
