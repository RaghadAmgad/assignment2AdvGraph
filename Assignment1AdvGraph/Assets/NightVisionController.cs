using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class NightVisionController : MonoBehaviour
{
    [SerializeField] private Color defaultLightColor;
    [SerializeField] private Color boostedLightColor;


    private bool isNightVisionEnabled;
    private PostProcessVolume volume;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.ambientLight = defaultLightColor;
        volume = gameObject.GetComponent<PostProcessVolume>();
        volume.weight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ToggleNightVision();
        }
    }
    private void ToggleNightVision()
    {
        isNightVisionEnabled = !isNightVisionEnabled;
        if (!isNightVisionEnabled)
        {
            RenderSettings.ambientLight = boostedLightColor;
            volume.weight = 1;
            print("There");
        }
        else
        {
            RenderSettings.ambientLight = defaultLightColor;
            
            volume.weight = 0;
            print("Here");
        }
    }
}
