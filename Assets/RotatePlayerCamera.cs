using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayerCamera : MonoBehaviour
{
    public float s = 8;
    public float upBound = 300;
    public float lowBound = 35;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float tempX = (transform.eulerAngles.x - (s * Input.GetAxis("Mouse Y")));
        if(tempX >= lowBound && tempX <= 180)
        {
            transform.eulerAngles = (new Vector3(lowBound, ((s * Input.GetAxis("Mouse X")) + transform.eulerAngles.y), 0));
        }
        else if(tempX <= upBound && tempX >= 180)
        {
            transform.eulerAngles = (new Vector3(upBound, ((s * Input.GetAxis("Mouse X")) + transform.eulerAngles.y), 0));
        }
        else
        {
            transform.eulerAngles = (new Vector3(tempX, ((s * Input.GetAxis("Mouse X")) + transform.eulerAngles.y), 0));
        }


        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
