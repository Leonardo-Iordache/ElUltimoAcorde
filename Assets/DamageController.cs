using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int enemyDamage;
    [SerializeField] private HealthController healthController;
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
