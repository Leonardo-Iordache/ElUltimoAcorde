using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour{
    public GameObject chest;
    public Transform m_newTransform;
    BoxCollider2D m_Collider;
    public bool isClosed = true;
    private SpriteRenderer rend_OpenedChest;
    private SpriteRenderer rend;
    private Vector3 pos;
    private BoxCollider2D player_col;

    void Start(){
        rend_OpenedChest = this.GetComponent<SpriteRenderer>();
        rend_OpenedChest.enabled = false;
        m_Collider = chest.GetComponent<BoxCollider2D>();
        player_col = m_newTransform.gameObject.GetComponent<BoxCollider2D>();
        rend = chest.gameObject.GetComponent<SpriteRenderer>();
    }

    void Update(){
        pos = m_newTransform.position;
        if(m_Collider.IsTouching(player_col)){
            if(Input.GetKey("e") && isClosed){
                OpenChest();
            }
        }
    }

    void OpenChest(){
        rend.enabled = false;
        rend_OpenedChest.enabled = true;
        isClosed = false;
    }
}