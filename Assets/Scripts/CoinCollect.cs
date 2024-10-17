using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{   
    // public AudioSource bling;
    //audio_update
    public GameObject Sparkle; //sparkle_update
    private Player player; //HUD_update
    //Audio_2nd_Update
    private CameraAudio cam_aud;
    
    void Start()
    {
        cam_aud = FindObjectOfType<CameraAudio>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {   //audio_2nd_update [fixed it: I used the main camera as both the audio source and audio listener; there's a script attactched to it and it has a public function called play_sound() which is called from here]
            cam_aud.play_sound();
            //audio_update
            //bling.Play();
            //HUD_update
            player.coins++;
            //sparkle_update
            Instantiate(Sparkle, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
