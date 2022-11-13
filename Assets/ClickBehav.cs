using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBehav : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider thisBC;
    void Start()
    {
        thisBC = GameObject.Find(name).GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitData;
            //Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if(Physics.Raycast(ray, out hitData))
            {
                BoxCollider bc = hitData.collider as BoxCollider;
                if( bc == thisBC)
                {
                    Destroy(bc.gameObject);
                }
            }

        }
    }
}
