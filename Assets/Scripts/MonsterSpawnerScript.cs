
using System.Collections;
using UnityEngine;

public class MonsterSpawnerScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] _monsters;

    [SerializeField]
    private Transform _leftPosition, _rightPosition;

    private GameObject _spawnedMonster;

    private int _randomIndex;
    private int _randomSide;

    private void Awake()
    {
    }

    IEnumerator SpawnMonsters()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));


            _randomIndex = Random.Range(0, _monsters.Length);
            _randomSide = Random.Range(0, 2);
            _spawnedMonster = Instantiate(_monsters[_randomIndex]);
    
            // left side
            if(_randomSide == 0)
            {
                _spawnedMonster.transform.position = _leftPosition.position;
                _spawnedMonster.GetComponent<MonsterBehaviourScript>().Monster.Speed = Random.Range(4, 10);
            }
            // right side
            else
            {
                _spawnedMonster.transform.position = _rightPosition.position;
                _spawnedMonster.GetComponent<MonsterBehaviourScript>().Monster.Speed = -Random.Range(4, 10);
                _spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
