using Assets.Constants;
using UnityEngine;

public class WallBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Constants.ENEMY_TAG))
        {
            Debug.Log("Entered Collision Enemy");
            Destroy(collision.gameObject);
        }
    }
}
