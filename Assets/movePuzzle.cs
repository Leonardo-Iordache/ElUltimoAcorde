using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePuzzle : MonoBehaviour{

    private SpriteRenderer rend;
    private Collider2D m_ObjectCollider;
    public Chest openedChest;
    private bool isActivated = false;


    void Start(){     
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        m_ObjectCollider = GetComponent<Collider2D>();
        rend.enabled = false;
    }

 
    void Update(){
        if(!openedChest.isClosed && !isActivated){
            isActivated = true;
            m_ObjectCollider.isTrigger = !m_ObjectCollider.isTrigger;
            rend.enabled = !rend.enabled;
        }
    }
}
