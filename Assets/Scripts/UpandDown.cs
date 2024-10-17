using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDown : MonoBehaviour
{
    public double amountToMove;
    private float startx;
    public float speed;
    private int direction;

    private float starty;//moving update
    private Player player;//moving update

    // Start is called before the first frame update
    void Start()
    {
        direction = 0;
        startx = gameObject.transform.position.y;
        player = FindObjectOfType<Player>();//New
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < startx + amountToMove && direction == 0)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y+ speed);
        }
        else if (gameObject.transform.position.y >= startx + amountToMove && direction == 0)
        {
            direction = 1;
        }
        else if (gameObject.transform.position.y > startx && direction == 1)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x , gameObject.transform.position.y- speed);
        }else if (gameObject.transform.position.y <= startx && direction == 1)
        {
            direction = 0;
        }
     

    }
    void OnCollisionEnter2D(Collision2D other){
            if(other.gameObject.CompareTag("Player")){
                player.transform.parent = gameObject.transform;
            }
    }
    void OnCollisionExit2D(Collision2D other) {
            if(other.gameObject.CompareTag("Player")){
                player.transform.parent = null;
            }
    }
}
