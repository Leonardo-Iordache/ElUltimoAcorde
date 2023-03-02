using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour{

    private Vector3 increment = new Vector3(0.1f, 0.1f, 0);
    public GameObject musicalNote;
    BoxCollider2D m_Collider;
    void Start(){
        musicalNote = GetComponent<GameObject>();
        m_Collider = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("notaMusical")){
            Debug.Log("Golpeado");

            transform.localScale += increment;
        }
    }
}
