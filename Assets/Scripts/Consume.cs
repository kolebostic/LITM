using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : MonoBehaviour
{
    public AudioSource crunch;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple") || other.CompareTag("RainApple"))
        {
            other.gameObject.SetActive(false);
            crunch.Play();
        }
    }
}
