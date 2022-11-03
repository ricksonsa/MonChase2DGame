using System;
using UnityEngine;

public class PlayerBehaviourScript : BasePlayerBehaviourScript
{
    private void Awake()
    {
        Body = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        MovementX = 0f;
        IsGrounded = true;
        Player = new Player();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ReadKeyboard();
    }

    void ReadKeyboard()
    {
        if (Input.GetKey("left")) MovementX = -1;
        else if (Input.GetKey("right")) MovementX = 1;

        AnimatePlayer();
        PlayerMoveCheck();
        
        MovementX = 0;
    
        if (Input.GetButtonDown("Jump"))
        {
            JumpPlayer();
        }
    }
}
