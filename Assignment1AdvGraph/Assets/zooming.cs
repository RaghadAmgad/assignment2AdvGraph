using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zooming : MonoBehaviour
{
    public Camera cam;
    public float defaultFov = 90;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            cam.fieldOfView = (defaultFov / 2);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            cam.fieldOfView = (defaultFov / 3);
        }

        else if (Input.GetKeyDown(KeyCode.C))
        {
            cam.fieldOfView = (defaultFov / 4);
        }

      

    }
}
