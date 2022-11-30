using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayStoreText : MonoBehaviour
{
    public TextMeshProUGUI upB;
    public TextMeshProUGUI upF;
    public TextMeshProUGUI autoB;
    public TextMeshProUGUI autoF;
    public TextMeshProUGUI pntB;
    public TextMeshProUGUI pntF;


    public TextMeshProUGUI ucB;
    public TextMeshProUGUI ucF;
    public TextMeshProUGUI acB;
    public TextMeshProUGUI acF;


    void Update()
    {
        upB.text = "Current Upgrade: x" + GlobalScoring.clickDmg.ToString();
        upF.text = "Current Upgrade: x" + GlobalScoring.clickDmg.ToString();

        autoB.text = "Current Auto: x" + GlobalScoring.autoClicks.ToString();
        autoF.text = "Current Auto: x" + GlobalScoring.autoClicks.ToString();

        pntB.text = "POINTS: " + GlobalScoring.points.ToString();
        pntF.text = "POINTS: " + GlobalScoring.points.ToString();


        ucB.text = "Cost: " + GlobalScoring.uCost.ToString();
        ucF.text = "Cost: " + GlobalScoring.uCost.ToString();

        acB.text = "Cost: " + GlobalScoring.aCost.ToString();
        acF.text = "Cost: " + GlobalScoring.aCost.ToString();
    }




    public void upgradeTool()
    {
        if(GlobalScoring.points >= GlobalScoring.uCost)
        {
            GlobalScoring.points -= GlobalScoring.uCost;
            GlobalScoring.clickDmg++;
            GlobalScoring.uCost *= 2;
        }
    }

    public void upgradeAuto()
    {
        if (GlobalScoring.points >= GlobalScoring.aCost)
        {
            GlobalScoring.points -= GlobalScoring.aCost;
            GlobalScoring.autoClicks++;
            GlobalScoring.aCost *= 4;
        }
    }
}
