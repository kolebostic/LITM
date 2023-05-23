using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketFullOfApples : MonoBehaviour
{
    public GameObject Hector;
    public GameObject apples;
    public GameObject darkness;
    public Material redApple;
    Renderer rend;

    void Start()
    {
        Hector.SetActive(false);
        apples.SetActive(false);
        rend = darkness.gameObject.GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (AutumnDataTracker.autumnGoodCount > 2)
        {
            Hector.SetActive(true);
            apples.SetActive(true);
            rend.sharedMaterial = redApple;
        }
    }
}
