using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_death : MonoBehaviour
{
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2( player.transform.position.x , transform.position.y);
    }
}
