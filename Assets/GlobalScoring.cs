using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScoring : MonoBehaviour
{
    public static int points = 50;      //currency system from "mining", use in store
    public static int autoClicks = 0;   //number of points being earned passively over time
    public static int level = 1;        //increases each scene change, determines "health" of crystals
    public static int clickDmg = 1;     //increasable in store, "weight" of each mouse click
    public static int itemsRemaining = 0; // number of gems/crystals still left in room
    public static int instances = 0;    //USED FOR DEBUGGING

    //costs for store upgrades
    public static int uCost = 5;
    public static int aCost = 50;
}
