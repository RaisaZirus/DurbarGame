using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int movespeed;
    public int jumppower;

    public Transform Ground_Check;
    public float Groundcheckradius;
    public LayerMask WhatIsGround;
    private bool OnGround;

    //controls_update
    public bool moveLeft;
    public bool moveRight;
    // anim_update
    private Animator anim;
    // facing_update
    private int facing ;
    //HUD_update
    public int coins;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();//anim_update
        facing = 1;
    }

    void FixedUpdate()
    {
        OnGround = Physics2D.OverlapCircle(Ground_Check.position, Groundcheckradius, WhatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A))|| moveLeft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            anim.SetBool("Walking", true);//anim_update
            if(facing == 1)
            {
                //transform.localScale = new Vector3(-1f, 1f, 1f);
                transform.Rotate(0f,180f,0f);
                facing = 0;
            }                               //facing_update
        }
        else if(Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)) || moveRight)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            anim.SetBool("Walking", true);//anim_update
            if (facing == 0)
            {
                //transform.localScale = new Vector3(1f, 1f, 1f);
                transform.Rotate(0f,180f,0f);
                facing = 1;                //facing_update
            }
        }
        else
        {
            anim.SetBool("Walking", false); //anim_update
        }
        //jumping 
        if  ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.W)) )
        {
            jump();
        }
    }

    public void jump()
    {
        if (OnGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumppower);
        }
    }

}
