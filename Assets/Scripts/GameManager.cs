using UnityEngine.SceneManagement;
using UnityEngine;
using Assets.Constants;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private GameObject[] _actors;

    private int _charIndex;
    public int CharIndex { get => _charIndex; set => _charIndex = value; }


    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        if (scene.name.Equals(Constants.GAMEPLAY_SCENE))
        {
            if(CharIndex == 0) Instantiate(_actors[CharIndex]);
            else
            {
                Instantiate(_actors[0]);
                Instantiate(_actors[1]);
            }
        }
    }
}
