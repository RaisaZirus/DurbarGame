using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    private Player player;
    public GameObject Blood; //blood_update/ player morar animation
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {   //blood_update
            Debug.Log("hazards");
            StartCoroutine("respawndelay"); 
        }
    }
    //delay_death_update

    public IEnumerator respawndelay()
    {
        Instantiate(Blood, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1);
        //checkpoint update
        float curr_start_x = PlayerPrefs.GetFloat("StartPosx") ;
        float curr_start_y = PlayerPrefs.GetFloat("StartPosy") ;
        player.transform.position = new Vector2(curr_start_x, curr_start_y);
        //checkpoint update
        player.GetComponent<Renderer>().enabled = true;
        player.enabled = true;

        //this is where "heroes never Die animation" takes place 
        //do this in the enemy script too
    }

}
