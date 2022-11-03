using UnityEngine;

public class WillisBehaviourScript : BasePlayerBehaviourScript
{

    PlayerControls _controls;
    private void Awake()
    {
        Body = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        MovementX = 0f;
        IsGrounded = true;
        Player = new Player();

        _controls = new PlayerControls();
        _controls.Enable();

        _controls.Gameplay.Jump.performed += ctx => JumpPlayer();

        _controls.Gameplay.WalkRight.performed += ctx => MoveRight(1);
        _controls.Gameplay.WalkRight.canceled += ctx => MovementX = 0;

        _controls.Gameplay.WalkLeft.performed += ctx => MoveLeft(-1);
        _controls.Gameplay.WalkLeft.canceled += ctx => MovementX = 0;


    }

    private void MoveRight(int value)
    {
        MovementX = value;
    }

    private void MoveLeft(int value)
    {
        MovementX = value;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AnimatePlayer();
        PlayerMoveCheck();
    }

   

    
}
