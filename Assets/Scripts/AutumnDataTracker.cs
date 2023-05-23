using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutumnDataTracker : MonoBehaviour
{
    public static bool autumnComplete;
    public static int autumnCount;
    public static int autumnGoodCount;
    public static int autumnBadCount;
    // Start is called before the first frame update
    void Start()
    {
        autumnComplete = false;
        autumnCount = 0;
        autumnGoodCount = 0;
        autumnBadCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (autumnGoodCount > 2 || autumnBadCount > 2)
        {
            autumnComplete = true;
        }
    }
}
