using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScoring : MonoBehaviour
{
    public static int points = 50;   //currency system from "mining", use in store
    public static int autoClicks = 0; //increase in store
    public static int level = 1;    //increases each scene change
    public static int clickDmg = 1; //increase in store with tool upgrade
    public static int itemsRemaining = 0; //number of gems/crystals still left in room
    public static int instances = 0;

    //for store
    public static int uCost = 5;
    public static int aCost = 50;
}
