using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isActive = false;
    public GameObject arrow;
    private BoxCollider thisBC;
    public string sceneName;
    public int levelInc;
    void Start()
    {
        arrow.SetActive(false);
        thisBC = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(thisBC == null)
        {
            thisBC = gameObject.GetComponent<BoxCollider>();
        }

        RaycastHit hitData;
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hitData))
        {
            BoxCollider bc = hitData.collider as BoxCollider;

            //manage appearance of arrow
            if (bc == thisBC && isActive == false)
            {
                isActive = true;
                arrow.SetActive(true);
            }
            else if (bc != thisBC && isActive == true)
            {
                isActive = false;
                arrow.SetActive(false);
            }

            //change scene of clicked
            if(Input.GetMouseButtonDown(0) && bc == thisBC)
            {
                GlobalScoring.level += levelInc;
                //load next scene
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
