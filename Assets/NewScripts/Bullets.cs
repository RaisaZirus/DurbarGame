using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    
    
    public float speed = 20f;
    public Rigidbody2D rb;
    public int Damageupon = 20;
    //public GameObject impactEffect;

    

    void Start()
    {
        
        rb.velocity = transform.right*speed;
        RmvAmmo();
    }

    void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log(other.name);
        if(other.tag == "Enemy"){
            Enemy enemy = other.GetComponent<Enemy>();
            if(enemy != null){
                enemy.TakeDamage(Damageupon);
                //this update is for the Ghost effect
                enemy.IncrVisibi();
                //this code increase visibility

                
            }
            //Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);   
            

        }

        //this is for ammo collecting
        else if(other.tag == "Ammo"){
            Ammo ammo = other.GetComponent<Ammo>();
            if(ammo != null){
                ammo.TakeDamage(Damageupon);
            }
            //Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);

            //extra for ammo
            
            
        }
    }
    void RmvAmmo(){
        int curr_num = PlayerPrefs.GetInt("PlayerAmmo",0);//hehe
        curr_num--;
        Debug.Log(curr_num);
        PlayerPrefs.SetInt("PlayerAmmo", curr_num);
    }
}
