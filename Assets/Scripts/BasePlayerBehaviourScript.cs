using Assets.Constants;
using UnityEngine;

public class BasePlayerBehaviourScript : MonoBehaviour
{
    public  Player Player;
    public float MovementX;
    public Rigidbody2D Body;
    public Animator Animator;
    public SpriteRenderer SpriteRenderer;
    public bool IsGrounded;

    public void AnimatePlayer()
    {
        Animator.SetBool(Constants.WALK_ANIMATION, MovementX != 0f);
        SpriteRenderer.flipX = MovementX < 0f;
    }

    public void PlayerMoveCheck()
    {
        transform.position += Player.MoveForce * Time.deltaTime * new Vector3(MovementX, 0f, 0f);
    }

    public void JumpPlayer()
    {
        Body.rotation = 0;
        if (IsGrounded)
        {
            IsGrounded = false;
            Body.AddForce(new Vector2(0f, Player.JumpForce), ForceMode2D.Impulse);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Constants.GROUND_TAG) 
            || collision.gameObject.CompareTag(Constants.PLAYER_TAG)
            || collision.gameObject.CompareTag(Constants.WILLIS_TAG)
            ) IsGrounded = true;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Constants.ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }
}

