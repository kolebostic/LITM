using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject queuedObject;

    void Start()
    {
        queuedObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Frog"))
        {
            queuedObject.SetActive(true);
        }
        else if (other.CompareTag("Bucket") && BucketDumper.hasWater)
        {
            queuedObject.SetActive(true);
        }
    }
}
