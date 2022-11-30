using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoClickManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int clock;
    void Start()
    {
        clock = 80;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalScoring.autoClicks > 0)
        {
            clock--;
            if (clock <= 0)
            {
                GlobalScoring.points += GlobalScoring.autoClicks;
                clock = 80;
            }
        }
    }
}
