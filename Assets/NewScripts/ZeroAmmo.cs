using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ZeroAmmo : MonoBehaviour
{
    public int nextLevel;
    public Animator Transitions;
    void Start()
    {
        //endLevel = GetComponent<EndLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        int curr_ammo = PlayerPrefs.GetInt("PlayerAmmo");
        if(curr_ammo == 0){
            StartCoroutine("LoadTransitions");//new trans update
            //endLevel.routineStartforLoad(1);
            PlayerPrefs.SetInt("PlayerAmmo", 10);
        }
    }
    IEnumerator LoadTransitions(){
        Transitions.SetTrigger("start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level1");//delete
    }
}
