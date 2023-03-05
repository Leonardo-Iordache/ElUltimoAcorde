using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fungiPuzzle : MonoBehaviour{
    
    public GameObject fungi;
    public Transform m_newTransform;
    BoxCollider2D m_Collider;

    
    private Vector3 pos;

    void Start(){
        m_Collider = GetComponent<BoxCollider2D>();
    }

    void Update(){
        pos = m_newTransform.position;
        if(m_Collider.bounds.Contains(pos)){
            if (Input.GetKey("e")){
                Remove();
            }
        }
    }
   

    void Remove(){
        
        Destroy(fungi);
    }
}