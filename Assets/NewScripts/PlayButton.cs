using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{
    public int howmanybulls = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartPlay(){
        //add base PlayerAmmo
        if(PlayerPrefs.HasKey("PlayerAmmo") == false){
            PlayerPrefs.SetInt("PlayerAmmo",howmanybulls);
        }else{
            PlayerPrefs.SetInt("PlayerAmmo",howmanybulls);
            //delete it in the final build
        }

        if(PlayerPrefs.HasKey("farthestLevel")){
            SceneManager.LoadScene($"Level{PlayerPrefs.GetInt("farthestLevel")+1}");
        }else{
            PlayerPrefs.SetInt("farthestLevel", 1);
            SceneManager.LoadScene("Level1");
        }

        //checkpoint update
        if(PlayerPrefs.HasKey("StartPosx") == false){
            PlayerPrefs.SetFloat("StartPosx",-26f);
        }else{
            PlayerPrefs.SetFloat("StartPosx",-26f);
            //delete it in the final build
        }
        if(PlayerPrefs.HasKey("StartPosy") == false){
            PlayerPrefs.SetFloat("StartPosy",-29f);
        }else{
            PlayerPrefs.SetFloat("StartPosy",-29f);
            //delete it in the final build
        }
    }
    

}
