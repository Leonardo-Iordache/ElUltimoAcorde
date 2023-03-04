using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notaMusical : MonoBehaviour{
    
    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D collision) {
        if( !collision.gameObject.name.Equals("player") ){
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1.5f);
            Destroy(gameObject);
        }
    }
}
