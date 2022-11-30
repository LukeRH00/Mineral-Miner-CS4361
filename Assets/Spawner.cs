using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject levelModel;
    public int totalSpawned;
    private Quaternion orient;
    public GameObject leaveText;

    void Start()
    {
        //Hide Level Progression Text
        leaveText.SetActive(false);

        //Get preset rotation of crystal prefab
        orient = Quaternion.Euler(levelModel.transform.eulerAngles.x, levelModel.transform.eulerAngles.y, levelModel.transform.eulerAngles.z);
        
        //Generate random number of crystals, update static variables
        totalSpawned = Random.Range(4, 8);
        GlobalScoring.itemsRemaining = totalSpawned;

        //Spawn crystals in random locations
        for(int i = 0; i < totalSpawned; i++)
        {
            //random radius and angle from center of room
            float dist = Random.Range(2.9f, 3.9f);
            float alpha = Random.Range(-Mathf.PI, Mathf.PI);
            Vector3 randLoc = new Vector3(Mathf.Cos(alpha), 0, Mathf.Sin(alpha)) * dist;
            
            //random height from cave floor
            randLoc.y = Random.Range(1.0f, 4.5f);
            Instantiate(levelModel, randLoc, orient);
        }
    }

    

    //Check if there are any crystals remaining
    //If not, make Level Progression Text Visible
    void Update()
    {
        if(GlobalScoring.itemsRemaining <= 0 && !leaveText.activeSelf)
        {
            leaveText.SetActive(true);
        }
    }
}
