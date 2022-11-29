using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScoring : MonoBehaviour
{
    public static int points;   //currency system from "mining", use in store
    public static int autoClicks; //increase in store
    public static int level;    //increases each scene change
    public static int clickDmg; //increase in store with tool upgrade

    private void Awake()
    {
        points = 0;
        autoClicks = 0;
        level = 1;
        clickDmg = 1;

        DontDestroyOnLoad(this.gameObject);
    }
}
