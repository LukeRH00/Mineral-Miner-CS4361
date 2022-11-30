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
        leaveText.SetActive(false);

        orient = Quaternion.Euler(levelModel.transform.eulerAngles.x, levelModel.transform.eulerAngles.y, levelModel.transform.eulerAngles.z);
        totalSpawned = Random.Range(4, 8);
        GlobalScoring.itemsRemaining = totalSpawned;

        for(int i = 0; i < totalSpawned; i++)
        {
            float dist = Random.Range(2.9f, 3.9f);
            float alpha = Random.Range(-Mathf.PI, Mathf.PI);
            Vector3 randLoc = new Vector3(Mathf.Cos(alpha), 0, Mathf.Sin(alpha)) * dist;
            randLoc.y = Random.Range(1.0f, 4.5f);
            Instantiate(levelModel, randLoc, orient);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalScoring.itemsRemaining <= 0 && !leaveText.activeSelf)
        {
            leaveText.SetActive(true);
        }
    }
}
