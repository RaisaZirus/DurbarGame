using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect; // the animation sprite
    private Player player;//checkpoint update
    public GameObject Blood;
    public int visibrecover = 2;//ghost enemy update
    void Start(){
        player = FindObjectOfType<Player>();
    }
    public void TakeDamage(int damage){
        health -= damage;
        if(health < 0){
            Die();
        }
    }
    void Die(){
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void IncrVisibi(){
        if((100-health) == visibrecover*20){
            gameObject.GetComponent<Renderer> ().enabled = true;//workssssssssss
        }
    }//this function is an update for the ghost enemy

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            StartCoroutine("respawndelay"); 
        }    
    }

    public IEnumerator respawndelay()
    {
        //ghost enemy update
        int curr_ammo = PlayerPrefs.GetInt("PlayerAmmo",0);//////////////
        curr_ammo--; 
        PlayerPrefs.SetInt("PlayerAmmo", curr_ammo);

        //move player to checkpoint
        Instantiate(Blood, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1);
        //checkpoint update
        float curr_start_x = PlayerPrefs.GetFloat("StartPosx",0f) ;///////////////
        float curr_start_y = PlayerPrefs.GetFloat("StartPosy",0f) ;
        player.transform.position = new Vector2(curr_start_x, curr_start_y);
        //checkpoint update
        player.GetComponent<Renderer>().enabled = true;
        player.enabled = true;

        //this is where "heroes never Die animation" takes place 
    }

}
