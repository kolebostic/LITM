using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketDumper : MonoBehaviour
{
    public static bool hasWater;
    public Material[] materials;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (hasWater == true)
        {
            if (other.gameObject.CompareTag("Sprouts"))
            {
                rend.sharedMaterial = materials[0];
                hasWater = false;
                print(hasWater);
            }
        }
    }
}
