using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (GameDataTracker.positivity > 5)
            {
                SceneManager.LoadScene(6);
            }
            else
            {
                SceneManager.LoadScene(7);
            }
        }
    }
}
