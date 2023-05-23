using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummerDataTracker : MonoBehaviour
{
    public static bool summerComplete;
    public static int summerCount;
    public static int summerGoodCount;
    public static int summerBadCount;
    // Start is called before the first frame update
    void Start()
    {
        summerComplete = false;
        summerCount = 0;
        summerGoodCount = 0;
        summerBadCount = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (summerGoodCount > 2 || summerBadCount > 2)
        {
            summerComplete = true;
        }
    }
}
