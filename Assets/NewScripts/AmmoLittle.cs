using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoLittle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
            if(PlayerPrefs.HasKey("PlayerAmmo")){
                int curr_num = PlayerPrefs.GetInt("PlayerAmmo",0);
                curr_num++;
                Debug.Log(curr_num);
                PlayerPrefs.SetInt("PlayerAmmo", curr_num);
            }else{
                PlayerPrefs.SetInt("PlayerAmmo", 1);
            }
            
        }    
    }
}
