using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndLevel : MonoBehaviour
{
    public int nextLevel;
    public int levelValue;
    public Animator Transitions;//new trans update
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="Player"){
            SaveLevel(levelValue);
            StartCoroutine("LoadTransitions");//new trans update
            
            
        }    
    }
    public void SaveLevel(int levelValue){
        PlayerPrefs.SetInt("farthestLevel", levelValue);
    }
    IEnumerator LoadTransitions(){
        Transitions.SetTrigger("start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene($"Level{nextLevel}");//delete
    }
}
