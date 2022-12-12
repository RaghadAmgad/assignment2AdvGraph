using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
          

                cam.fieldOfView -= 20;
            
          

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cam.fieldOfView += 20;

        }
    }
}
