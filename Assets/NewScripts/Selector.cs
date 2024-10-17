using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Selector : MonoBehaviour
{
    public bool moveLeft;
    public bool moveRight;
    public float startPoint, endPoint,increm;
    public string LevelChoice;
    void Update()
    {
        if(transform.position.x > startPoint && (moveLeft || Input.GetKeyDown(KeyCode.LeftArrow))){
            transform.position = new Vector2(transform.position.x - increm, transform.position.y);
            moveLeft = false;
        }
        else if(transform.position.x < endPoint && (moveRight || Input.GetKeyDown(KeyCode.RightArrow))){
            transform.position = new Vector2(transform.position.x + increm, transform.position.y);
            moveRight = false;//these are for android controls, I don't need that
        }
        if(Input.GetKey(KeyCode.Space)){
            Select();
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        LevelChoice = other.name;
        Debug.Log($"{LevelChoice}");
    }
    public void Select(){
        //let's see if we can implement the new go to level logic here
        if(PlayerPrefs.HasKey("farthestLevel")){
            int farlevel = PlayerPrefs.GetInt("farthestLevel",0);///////////
            int curr_num = LevelChoice[5]-'0';
            Debug.Log(curr_num);
            if(farlevel >= curr_num){
                SceneManager.LoadScene(LevelChoice);    
            }
        }
        
        
    }
}
