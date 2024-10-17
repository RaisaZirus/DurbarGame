using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointMake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //make whoever you're assigning this to, a trigger 
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="Player"){
            float curr_x = transform.position.x;
            float curr_y = transform.position.y;
            //here we have taken the checkpoint's cordinates and stored it
            PlayerPrefs.SetFloat("StartPosx", curr_x);
            PlayerPrefs.SetFloat("StartPosy", curr_y);
        }    
    }
}
