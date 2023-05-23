using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinterDataTracker : MonoBehaviour
{
    public static bool winterComplete;
    public static int winterCount;
    public static int winterGoodCount;
    public static int winterBadCount;
    // Start is called before the first frame update
    void Start()
    {
        winterComplete = false;
        winterCount = 0;
        winterGoodCount = 0;
        winterBadCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(winterGoodCount > 2 || winterBadCount > 2)
        {
            winterComplete = true;
        }
    }
}
