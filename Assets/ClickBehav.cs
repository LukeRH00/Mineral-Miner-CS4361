using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehav : MonoBehaviour
{
    // Start is called before the first frame update
    //public BoxCollider thisBC;
    public MeshCollider thisMC;
    private int hp;

    float rotSpeed = 8;
    void Start()
    {
        thisMC = gameObject.GetComponent<MeshCollider>();
        hp = GlobalScoring.level;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !PauseScript.isPaused)
        {
            RaycastHit hitData;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if(Physics.Raycast(ray, out hitData))
            {
                MeshCollider bc = hitData.collider as MeshCollider;
                if( bc == thisMC)
                {
                    hp -= GlobalScoring.clickDmg;
                    if(hp <= 0)
                    {
                        //add points (for store)
                        GlobalScoring.itemsRemaining -= 1;
                        GlobalScoring.points++;
                        Destroy(bc.gameObject);
                    }
                }
            }

        }
        else
        {
            //rotate here
            gameObject.transform.Rotate(0.0f, rotSpeed * ((GlobalScoring.level - hp) / (float)(GlobalScoring.level)), 0.0f, Space.World);
        }
    }
}
