using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bulletPrefab;
    void Update()
    {
        if(/*Input.GetButtonDown("Fire1") ||*/ (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.Space)/*||(Input.GetKeyDown(KeyCode.DownArrow))*/)){
            int curr_num = PlayerPrefs.GetInt("PlayerAmmo",0);
            if(curr_num>0){
                Shoot();
            }
        }
    }
    void Shoot(){
        //shooting logic
        Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
    }
}
