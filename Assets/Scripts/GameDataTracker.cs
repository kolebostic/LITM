using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDataTracker : MonoBehaviour
{
    private Scene currentScene;
    private string sceneName;
    public static int scenesCompleted = -1;
    public static int positivity = 0;
    public GameObject springGateway;
    public GameObject summerGateway;
    public GameObject autumnGateway;
    public GameObject winterGateway;
    public GameObject endGateway;
    // [SerializeField] private AudioSource inThePark;

    public static GameDataTracker instance
    {
        get;
        set;
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        instance = this;
    }
    // Start is called before the first frame update
    public void Start()
    {
        springGateway.SetActive(!SpringDataTracker.springComplete);
        summerGateway.SetActive(!SummerDataTracker.summerComplete);
        autumnGateway.SetActive(!AutumnDataTracker.autumnComplete);
        winterGateway.SetActive(!WinterDataTracker.winterComplete);
        endGateway.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (SpringDataTracker.springComplete && SummerDataTracker.summerComplete && AutumnDataTracker.autumnComplete && WinterDataTracker.winterComplete)
        {
            endGateway.SetActive(true);
        }
    }
}
