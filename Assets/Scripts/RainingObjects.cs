using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingObjects : MonoBehaviour
{
    public GameObject spawnedObject;
    // Start is called before the first frame update
    void Start()
    {
        spawnedObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DropFrog()
    {
        spawnedObject.SetActive(true);
        GameObject rainingObject;
        float x = Random.Range(-10.0f, 10.0f);
        float z = Random.Range(-10.0f, 10.0f);
        rainingObject = Instantiate(spawnedObject, new Vector3(x, 12, z), Quaternion.identity);
    }
}
