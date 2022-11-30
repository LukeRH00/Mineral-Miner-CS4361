using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    //displays current points on screen of main UI
    void Update()
    {
        score.text = "POINTS: " + GlobalScoring.points.ToString();
    }
}
