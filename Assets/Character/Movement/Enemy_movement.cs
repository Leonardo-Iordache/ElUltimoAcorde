using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    public Rigidbody2D rb;
    private character_movement hero;
    public float moveSpeed;
    public Vector3 directionToPlayer;
    public Vector3 localScale;
    public int enemyHealth;


    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        hero = FindObjectOfType(typeof(character_movement)) as character_movement;
        moveSpeed = 0.75f;
        localScale = transform.localScale;

    }
    void FixedUpdate() {
        MoveEnemy();
    }
    void MoveEnemy(){
        directionToPlayer = (hero.transform.position - transform.position).normalized;
        rb.velocity = new Vector2(directionToPlayer.x, directionToPlayer.y)*moveSpeed;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if(rb.velocity.x >0){
            transform.localScale=new Vector3(localScale.x,localScale.y,localScale.z);
        }
        else if(rb.velocity.x <0){
            transform.localScale=new Vector3(-localScale.x,localScale.y,localScale.z);
        }

    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag.Equals("notaMusical")){
            enemyHealth = enemyHealth-1; 
            if(enemyHealth == 0){
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
            else{
                Destroy(collision.gameObject);
            }
        }
    }
}