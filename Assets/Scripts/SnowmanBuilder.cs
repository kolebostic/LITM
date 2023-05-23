using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanBuilder : MonoBehaviour
{
    public GameObject snowball1;
    public GameObject snowball2;
    public GameObject snowball3;
    public GameObject snowman;
    public GameObject key;
    public int currentPositivity;
    // Start is called before the first frame update
    void Start()
    {
        currentPositivity = GameDataTracker.positivity;
        snowball1.SetActive(false);
        snowball2.SetActive(false);
        snowball3.SetActive(false);
        snowman.SetActive(false);
        key.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snowball1"))
        {
            snowball1.SetActive(true);
            other.gameObject.SetActive(false);
            GameDataTracker.positivity += 1;
            WinterDataTracker.winterCount += 1;
        }
        if (other.CompareTag("Snowball2"))
        {
            snowball2.SetActive(true);
            other.gameObject.SetActive(false);
            GameDataTracker.positivity += 1;
            WinterDataTracker.winterCount += 1;
        }
        if (other.CompareTag("Snowball3"))
        {
            snowball3.SetActive(true);
            other.gameObject.SetActive(false);
            GameDataTracker.positivity += 1;
            WinterDataTracker.winterCount += 1;
        }
        if (GameDataTracker.positivity > (currentPositivity + 2))
        {
            snowman.SetActive(true);
            key.SetActive(true);
            snowball1.SetActive(false);
            snowball2.SetActive(false);
            snowball3.SetActive(false);
        }
    }
}
