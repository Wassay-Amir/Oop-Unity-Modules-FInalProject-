using UnityEngine;

public class BatteryController : MonoBehaviour
{
    public Renderer lightRenderer;

    void Start()
    {
        SetLight(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SetLight(true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            SetLight(false);
        }
    }

    void SetLight(bool isOn)
    {
        if (isOn)
        {
            lightRenderer.material.EnableKeyword("_EMISSION");
            lightRenderer.material.SetColor("_EmissionColor", Color.green * 5f);
        }
        else
        {
            lightRenderer.material.SetColor("_EmissionColor", Color.black);
        }
    }
}