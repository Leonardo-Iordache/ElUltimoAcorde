using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_damageController : MonoBehaviour
{
    [SerializeField] private int enemyDamage;
    [SerializeField] private Character_health healthController;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            Damage();
        }

    }
    void Damage(){
        healthController.heroHealth = healthController.heroHealth - enemyDamage;
        healthController.UpdateHealth();
    }
}
