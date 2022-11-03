using Assets.Constants;
using UnityEngine;

public class PlayerCameraBehaviour : MonoBehaviour
{
    private Transform _player;
    private Vector3 _position;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag(Constants.PLAYER_TAG).transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (_player)
        {
            _position = transform.position;
            _position.x = _player?.position.x ?? 0;

            transform.position = _position;
        }
    }
}
