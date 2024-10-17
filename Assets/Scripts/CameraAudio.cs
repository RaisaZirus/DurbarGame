using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAudio : MonoBehaviour
{
    public AudioSource bling; 

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void play_sound()
    {
        bling.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
