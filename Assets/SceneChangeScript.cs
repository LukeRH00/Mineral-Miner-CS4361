using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    //arrows tied to cave entrances
    private bool isActive = false;
    public GameObject arrow;

    //for click registration on text
    private BoxCollider thisBC;

    //for next scene and level increment
    public string sceneName;
    public int levelInc;


    //set arrows to be invisible
    void Start()
    {
        arrow.SetActive(false);
        thisBC = gameObject.GetComponent<BoxCollider>();
    }

    

    void Update()
    {
        //get text's collision mesh if it didn't at the start
        if(thisBC == null)
        {
            thisBC = gameObject.GetComponent<BoxCollider>();
        }


        //Determine if camera is looking at cave entrance
        RaycastHit hitData;
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hitData))
        {
            BoxCollider bc = hitData.collider as BoxCollider;

            //make arrow visible if camera is pointing at entrance
            if (bc == thisBC && isActive == false)
            {
                isActive = true;
                arrow.SetActive(true);
            }
            //hide arrow if camera is looking away from entrance
            else if (bc != thisBC && isActive == true)
            {
                isActive = false;
                arrow.SetActive(false);
            }

            //change scene of mouse clicked while camera is viewing entrance
            if(Input.GetMouseButtonDown(0) && bc == thisBC)
            {
                GlobalScoring.level += levelInc;
                //load next scene
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
