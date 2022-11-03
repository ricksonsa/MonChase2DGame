using Assets.Constants;
using UnityEngine;

public class MonsterBehaviourScript : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _body;
    public Monster Monster { get; set; } = new Monster();

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        Monster = new();

        AnimateMonster();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        _body.velocity = new Vector2(Monster.Speed, _body.velocity.y);
    }

    public void AnimateMonster()
    {
        _animator.SetBool(Constants.WALK_ANIMATION, true);
    }
}
