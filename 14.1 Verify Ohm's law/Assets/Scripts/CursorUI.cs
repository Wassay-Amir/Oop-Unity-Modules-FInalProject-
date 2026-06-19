using UnityEngine;
using UnityEngine.UI;

public class CursorUI : MonoBehaviour
{
    [SerializeField] private Image crosshair;
    [SerializeField] private Color normalColor = Color.white;
    [SerializeField] private Color hoverColor = Color.yellow;

    private void Start()
    {
        // Hide OS cursor
        Cursor.visible = false;
    }

    private void Update()
    {
        // Check if pointing at instrument
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10f))
        {
            if (hit.collider.CompareTag("Instrument"))
            {
                // Highlight when pointing at instrument
                crosshair.color = hoverColor;
            }
            else
            {
                crosshair.color = normalColor;
            }
        }
        else
        {
            crosshair.color = normalColor;
        }
    }
}