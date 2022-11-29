using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject levelModel;
    public int totalSpawned;
    void Start()
    {
        totalSpawned = Random.Range(3, 5);
        for(int i = 0; i < totalSpawned; i++)
        {
            float dist = Random.Range(2.5f, 3.9f);
            float alpha = Random.Range(-Mathf.PI, Mathf.PI);
            Vector3 randLoc = new Vector3(Mathf.Cos(alpha), 0, Mathf.Sin(alpha)) * dist;
            randLoc.y = Random.Range(1.0f, 4.5f);
            Instantiate(levelModel, randLoc, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
