using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public int heroHealth;
    [SerializeField] private Image[] hearts;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth(){
        if(heroHealth==0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        for(int i=0; i< hearts.Length;i++){
            if(i<heroHealth){
                hearts[i].color = Color.white;

            }
            else{
                hearts[i].color = Color.black;
            }
        
        } 
    }
}
