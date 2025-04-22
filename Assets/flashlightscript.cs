using UnityEngine;
using UnityEngine.Rendering.Universal;

public class flashlightscript : MonoBehaviour
{
    [SerializeField] private Light2D lightFlash;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {

            lightFlash.enabled = !lightFlash.enabled;

        }
    }
}
