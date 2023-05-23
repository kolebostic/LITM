using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTossTag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
        }

    }
}
