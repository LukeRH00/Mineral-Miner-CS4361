using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    // Update is called once per frame
    void Update()
    {
        score.text = "POINTS: " + GlobalScoring.points.ToString();
    }
}
