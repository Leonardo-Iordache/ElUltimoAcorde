using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour{
    
    public Transform firePoint;
    public GameObject musicNotePrefab;

    public float musicalNoteSpeed = 4f;

    // Update is called once per frame
    void Update(){
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }



    void Shoot(){
        //shooting logic
        GameObject musicalNote = Instantiate(musicNotePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = musicalNote.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * musicalNoteSpeed, ForceMode2D.Impulse);
    }
}
