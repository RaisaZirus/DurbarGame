using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 0;
    public GameObject Scattered_coins; // the animation sprite

    public void TakeDamage(int damage){
        health -= damage;
        if(health < 0){
            Die();
        }
    }
    void Die(){
        Instantiate(Scattered_coins, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
