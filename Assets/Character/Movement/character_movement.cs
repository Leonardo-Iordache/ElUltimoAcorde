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

    void Start() {
        firePoint = GameObject.Find("firePoint");    
    }

    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");



        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        updateDireccion();
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
        
        //transform.Rotate(0f, 180f, 0f);

        /*Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        */
    }

    void updateDireccion(){
        if( movement != Vector2.zero ){
            animator.SetFloat("dirx", movement.x);
            animator.SetFloat("diry", movement.y);
            animator.Play("caminar");
        } else {
            animator.Play("quieto");
        }
        
        /*if( movement != Vector2.zero ){
            animator.Play("quieto");
        } else {
            animator.Play("caminar");
        }*/
    }


}




