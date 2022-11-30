using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayerCamera : MonoBehaviour
{
    //camera sensitivity
    public float s = 8;

    //camera upper/lower bounds
    public float upBound = 300;
    public float lowBound = 35;
    
    //hide cursor while in-game
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    

    void Update()
    {
        //only move camera while not paused
        if (!PauseScript.isPaused)
        {

            //get vertical mouse movement
            float tempX = (transform.eulerAngles.x - (s * Input.GetAxis("Mouse Y")));

            //if vertical mov is below lowerBound
            if (tempX >= lowBound && tempX <= 180)
            {
                //only update horizontal mov, set Vert to lower bound
                transform.eulerAngles = (new Vector3(lowBound, ((s * Input.GetAxis("Mouse X")) + transform.eulerAngles.y), 0));
            }
            //if vertical mov is above upperBound
            else if (tempX <= upBound && tempX >= 180)
            {
                //only update horizontal mov, set Vert to upper bound 
                transform.eulerAngles = (new Vector3(upBound, ((s * Input.GetAxis("Mouse X")) + transform.eulerAngles.y), 0));
            }
            else
            {
                //update camera rotation vector to mouse movement
                transform.eulerAngles = (new Vector3(tempX, ((s * Input.GetAxis("Mouse X")) + transform.eulerAngles.y), 0));
            }
        }
    }
}
