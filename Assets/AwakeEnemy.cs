using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeEnemy : MonoBehaviour
{
    
    public Enemy enemy;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag.Equals("Player")){
            enemy.awake();
            Destroy(this.gameObject);
        }
    }
}
