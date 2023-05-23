using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TagDestroyer : MonoBehaviour
{
    public GameObject spawnedObject;
    public GameObject key;
    public GameObject[] opposingObjects;
    public GameObject[] snowmanBalls;
    public AudioSource[] audioList;
    public GameObject fire;
    public GameObject[] fireLogs;
    public GameObject snowman;
    public GameObject selfObject;
    public static int applesEaten;
    private Scene currentScene;
    private string sceneName;
    public static int currentPositivity;

    public void Start()
    {
        currentPositivity = GameDataTracker.positivity;
        spawnedObject.SetActive(false);
        key.SetActive(false);
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "WinterScene")
        {
            foreach (GameObject ball in snowmanBalls)
            {
                ball.SetActive(false);
            }
            foreach (GameObject log in fireLogs)
            {
                log.SetActive(false);
            }
            snowman.SetActive(false);
            fire.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (sceneName == "SpringScene")
        {
            if (other.CompareTag("Frog") && selfObject.CompareTag("Lilipad"))
            {
                GameDataTracker.positivity += 1;
                SpringDataTracker.springCount += 1;
                SpringDataTracker.springGoodCount += 1;
                print(SpringDataTracker.springCount);
                other.gameObject.SetActive(false);
            }
            else if (other.CompareTag("Frog") && selfObject.CompareTag("WaterCollider"))
            {
                SpringDataTracker.springCount += 1;
                SpringDataTracker.springBadCount += 1;
                other.gameObject.SetActive(false);
            }
            if (SpringDataTracker.springGoodCount > 2 || SpringDataTracker.springBadCount > 2)
            {
                key.SetActive(true);
                spawnedObject.SetActive(true);
                InvokeRepeating(nameof(RainObject), 1, 1.0f);
                Invoke(nameof(StopRainObject), 10);
                foreach (GameObject frog in opposingObjects)
                {
                    frog.SetActive(false);
                }
            }
        }
        else if (sceneName == "SummerScene")
        {
            if (other.CompareTag("Bee") && selfObject.CompareTag("Finch"))
            {
                SummerDataTracker.summerCount += 1;
                SummerDataTracker.summerBadCount += 1;
                print(SummerDataTracker.summerCount);
                other.gameObject.SetActive(false);
            }
            else if (other.CompareTag("Bucket") && BucketDumper.hasWater && selfObject.CompareTag("Sprouts"))
            {
                SummerDataTracker.summerCount += 1;
                SummerDataTracker.summerGoodCount += 1;
                GameDataTracker.positivity += 1;
                selfObject.SetActive(false);
            }
            if (SummerDataTracker.summerGoodCount > 2)
            {
                key.SetActive(true);
                spawnedObject.SetActive(true);
                InvokeRepeating(nameof(RainObject), 1, 1.0f);
                Invoke(nameof(StopRainObject), 10);
                foreach (GameObject bee in opposingObjects)
                {
                    bee.SetActive(false);
                }
            }
            else if (SummerDataTracker.summerBadCount > 2)
            {
                key.SetActive(true);
                spawnedObject.SetActive(true);
                InvokeRepeating(nameof(RainObject), 1, 1.0f);
                Invoke(nameof(StopRainObject), 10);
                foreach (GameObject bucket in opposingObjects)
                {
                    bucket.SetActive(false);
                }
            }
        }
        else if (sceneName == "FallScene")
        {
            if (other.gameObject.CompareTag("Apple") && selfObject.gameObject.CompareTag("Player"))
            {
                AutumnDataTracker.autumnCount += 1;
                applesEaten += 1;
                if (applesEaten % 2 == 1)
                {
                    AutumnDataTracker.autumnBadCount += 1;
                }
                other.gameObject.SetActive(false);
            }
            else if (other.CompareTag("Apple") && !selfObject.CompareTag("Player"))
            {
                GameDataTracker.positivity += 1;
                AutumnDataTracker.autumnCount += 1;
                AutumnDataTracker.autumnGoodCount += 1;
                other.gameObject.SetActive(false);
            }
            if (AutumnDataTracker.autumnGoodCount > 2 || AutumnDataTracker.autumnBadCount > 2)
            {
                key.SetActive(true);
                spawnedObject.SetActive(true);
                InvokeRepeating(nameof(RainObject), 1, 1.0f);
                Invoke(nameof(StopRainObject), 20);
                foreach (GameObject apple in opposingObjects)
                {
                    apple.SetActive(false);
                }
            }
        }
        else if (sceneName == "WinterScene")
        {
            if (other.CompareTag("Log") && selfObject.CompareTag("Stump"))
            {
                WinterDataTracker.winterCount += 1;
                WinterDataTracker.winterBadCount += 1;
                fireLogs[0].SetActive(true);
                other.gameObject.SetActive(false);
                print(WinterDataTracker.winterBadCount);
            }
            if (other.CompareTag("Log1") && selfObject.CompareTag("Stump"))
            {
                WinterDataTracker.winterCount += 1;
                WinterDataTracker.winterBadCount += 1;
                fireLogs[1].SetActive(true);
                other.gameObject.SetActive(false);
                print(WinterDataTracker.winterBadCount);
            }
            if (other.CompareTag("Log2") && selfObject.CompareTag("Stump"))
            {
                WinterDataTracker.winterCount += 1;
                WinterDataTracker.winterBadCount += 1;
                fireLogs[2].SetActive(true);
                other.gameObject.SetActive(false);
                print(WinterDataTracker.winterBadCount);
            }
            if (other.CompareTag("Snowball1") && selfObject.CompareTag("SnowmanMaker"))
            {
                snowmanBalls[0].SetActive(true);
                other.gameObject.SetActive(false);
                GameDataTracker.positivity += 1;
                WinterDataTracker.winterCount += 1;
                WinterDataTracker.winterGoodCount += 1;
            }
            if (other.CompareTag("Snowball2") && selfObject.CompareTag("SnowmanMaker"))
            {
                snowmanBalls[1].SetActive(true);
                other.gameObject.SetActive(false);
                GameDataTracker.positivity += 1;
                WinterDataTracker.winterCount += 1;
                WinterDataTracker.winterGoodCount += 1;
            }
            if (other.CompareTag("Snowball3") && selfObject.CompareTag("SnowmanMaker"))
            {
                snowmanBalls[2].SetActive(true);
                other.gameObject.SetActive(false);
                GameDataTracker.positivity += 1;
                WinterDataTracker.winterCount += 1;
                WinterDataTracker.winterGoodCount += 1;
            }
            if (WinterDataTracker.winterGoodCount > 2)
            {
                key.SetActive(true);
                snowman.SetActive(true);
                snowmanBalls[0].SetActive(false);
                snowmanBalls[1].SetActive(false);
                snowmanBalls[2].SetActive(false);
                spawnedObject.SetActive(true);
                InvokeRepeating(nameof(RainObject), 1, 1.0f);
                Invoke(nameof(StopRainObject), 20);
                foreach (GameObject log in opposingObjects)
                {
                    log.SetActive(false);
                }
            }
            if (WinterDataTracker.winterBadCount > 2)
            {
                key.SetActive(true);
                fire.SetActive(true);
                spawnedObject.SetActive(true);
                InvokeRepeating(nameof(RainObject), 1, 1.0f);
                Invoke(nameof(StopRainObject), 20);
                foreach (GameObject ball in opposingObjects)
                {
                    ball.SetActive(false);
                }
            }
        }
    }
    public void RainObject()
    {
        GameObject rainingObject;
        float x = Random.Range(-10.0f, 10.0f);
        float z = Random.Range(-10.0f, 10.0f);
        rainingObject = Instantiate(spawnedObject, new Vector3(x, 12, z), Quaternion.identity);
    }

    public void StopRainObject()
    {
        CancelInvoke(nameof(RainObject));
    }
}
       
