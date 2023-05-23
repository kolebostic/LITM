using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringDataTracker : MonoBehaviour
{
    public static bool springComplete;
    public static int springCount;
    public static int springGoodCount;
    public static int springBadCount;

    public void Start()
    {
        springComplete = false;
        springCount = 0;
        springGoodCount = 0;
        springBadCount = 0;
    }

    private void Update()
    {
        if(springGoodCount > 2 || springBadCount > 2)
        {
            springComplete = true;
        }
    }
}
