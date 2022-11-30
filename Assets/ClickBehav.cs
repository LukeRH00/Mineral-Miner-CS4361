using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehav : MonoBehaviour
{
    //vars for crystal object and health
    public MeshCollider thisMC;
    private int hp;

    //constant for calculating rotation
    float rotSpeed = 8;
    
    //set variables
    void Start()
    {
        thisMC = gameObject.GetComponent<MeshCollider>();
        hp = GlobalScoring.level;
    }

    
    void Update()
    {
        //determine if mouse was clicked while unpaused
        if (Input.GetMouseButtonDown(0) && !PauseScript.isPaused)
        {
            //Raycast:: retrieve vector of camera orientation, find first object vector hits
            RaycastHit hitData;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if(Physics.Raycast(ray, out hitData))
            {
                //determine if object from raycast is same as current object
                MeshCollider bc = hitData.collider as MeshCollider;
                if( bc == thisMC)
                {
                    //decrease health, determine whether to destroy object
                    hp -= GlobalScoring.clickDmg;
                    if(hp <= 0)
                    {
                        //add points if destroyed, decrement # of remaining crystals in room
                        GlobalScoring.itemsRemaining -= 1;
                        GlobalScoring.points++;
                        Destroy(bc.gameObject);
                    }
                }
            }

        }
        else
        {
            //Rotate if not destroyed: lower the "health", the faster the rotation
            gameObject.transform.Rotate(0.0f, rotSpeed * ((GlobalScoring.level - hp) / (float)(GlobalScoring.level)), 0.0f, Space.World);
        }
    }
}
