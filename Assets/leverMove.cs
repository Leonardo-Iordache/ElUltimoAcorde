using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverMove : MonoBehaviour{
    
    public GameObject obj;
    public Transform m_newTransform;
    BoxCollider2D m_Collider;
    private int useCooldown = 50;
    private bool hasUse = true;

    
    private bool isMoved = false;
    private Vector3 pos, objPos, posIni;

    void Start(){
        m_Collider = GetComponent<BoxCollider2D>();
        posIni = obj.transform.position;
    }

    void FixedUpdate(){
        pos = m_newTransform.position;
        if(useCooldown == 0){
            hasUse = true;
        }
        else{
            useCooldown--;
        }
        if(m_Collider.bounds.Contains(pos) && (hasUse==true)){
            if (Input.GetKey("e") && (isMoved==false)){
                hasUse = false;
                MoveObject();
            }
            else if(Input.GetKey("e") && (isMoved==true)){
                hasUse = false;
                ReturnObject();
            }
        }
    }
   

    void MoveObject(){
        objPos = new Vector3(obj.transform.position.x - 250000f, obj.transform.position.y + 0.5f);
        obj.transform.position = objPos;
        isMoved=true;
        hasUse = false;
        useCooldown = 50;
    }
    void ReturnObject(){
        obj.transform.position = posIni;
        isMoved=false;
        hasUse = false;
        useCooldown = 50;

    }
}   