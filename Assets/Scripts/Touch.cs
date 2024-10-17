using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    
    public void PressLeftArrow()
    {
        player.moveLeft = true;
        player.moveRight = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveLeft = false;
    }
    public void PressRightArrow()
    {
        player.moveLeft = false;
        player.moveRight = true;
    }
    public void ReleaseRightArrow()
    {
        player.moveRight = false;
    }
    public void Jump()
    {
        player.jump();
    }

}
