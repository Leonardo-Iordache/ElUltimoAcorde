using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_movement : MonoBehaviour{
    // Start is called before the first frame update

    public float playerSpeed = 2.0f;
    private bool facingRight = true;
    Vector2 movement;
    Vector2 mousePos;
    public Rigidbody2D player_rb;
    public GameObject firePoint;
    public Camera cam;

    [SerializeField] private Animator animator;

    private int direccion = 2;

    void Start() {
        firePoint = GameObject.Find("firePoint");    
    }

    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        updateDireccion();
        AnimateMovement();
    }

    //comentario de prueba

    void FixedUpdate() {
        player_rb.MovePosition(player_rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        
        if (movement.x > 0 && !facingRight){
            Flip();
        }
        else if(movement.x < 0 && facingRight){
            Flip();
        }


        Vector2 firePoint_Direction = mousePos - player_rb.position;
        float angle = Mathf.Atan2(firePoint_Direction.y, firePoint_Direction.x) * Mathf.Rad2Deg - 90f;

        firePoint.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }    

    void Flip(){
        facingRight = !facingRight;
        
        transform.Rotate(0f, 180f, 0f);

        /*Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        */
    }

    void updateDireccion(){
        if (Input.GetKeyDown(KeyCode.W)){ direccion = 0; }
        else if (Input.GetKeyDown(KeyCode.D)){ direccion = 1; }
        else if (Input.GetKeyDown(KeyCode.S)){ direccion = 2; }
        else if (Input.GetKeyDown(KeyCode.A)){ direccion = 1; }
    }

    void AnimateMovement(){
        animator.SetInteger("direccion", direccion);
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A)){ animator.SetBool("se_mueve", true); }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A)){ animator.SetBool("se_mueve", false); }
    }

}




