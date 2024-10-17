using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   //HUD_update_here_text_is_a_type
    Text coins;
    //private Player player;//delete after new
    // Start is called before the first frame update
    void Start()
    {
        //player = FindObjectOfType<Player>();//delete after new
        coins = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int curr_ammo = PlayerPrefs.GetInt("PlayerAmmo");
        coins.text = $"{curr_ammo}";
    }
}
