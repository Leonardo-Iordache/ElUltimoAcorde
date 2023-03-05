using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour{
    
    public GameObject door;
    public Transform m_newTransform;
    BoxCollider2D m_Collider;

    
    private bool isClosed = true;
    private Vector3 pos, doorPos;

    void Start(){
        m_Collider = GetComponent<BoxCollider2D>();
    }

    void Update(){
        pos = m_newTransform.position;
        if(m_Collider.bounds.Contains(pos)){
            if (Input.GetKey("e") && isClosed){
                OpenDoor();
            }
        }
    }
   

    void OpenDoor(){
        doorPos = new Vector3(door.transform.position.x, door.transform.position.y + 0.5f);
        door.transform.position = Vector3.MoveTowards(door.transform.position, doorPos, 0.5f);
        isClosed = false;
        Destroy(door, 1.5f);
    }
}