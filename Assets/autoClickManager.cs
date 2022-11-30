using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoClickManager : MonoBehaviour
{
    //internal clock for auto-click feature
    private int clock;
    void Start()
    {
        clock = 80;
    }

    

    void Update()
    {
        //only calculate clock if there is at least one autoClicker
        if (GlobalScoring.autoClicks > 0)
        {
            //decrement clock, check if 0
            clock--;
            if (clock <= 0)
            {
                //if 0, reset clock, increase points by autoClick amount
                GlobalScoring.points += GlobalScoring.autoClicks;
                clock = 80;
            }
        }
    }
}
