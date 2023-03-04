using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decrease : MonoBehaviour{
    // Start is called before the first frame update
    private Vector3 decrement = new Vector3(0.1f, 0.1f, 0);
    public GameObject musicalNote;
    BoxCollider2D m_Collider;
    void Start(){
        musicalNote = GetComponent<GameObject>();
        m_Collider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("notaMusical") && transform.localScale.x > 0.1f){
            Debug.Log("Golpeado");

            transform.localScale -= decrement;
        }
    }
}
