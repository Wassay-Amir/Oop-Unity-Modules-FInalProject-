using UnityEngine;

public class ManualUI : MonoBehaviour
{
    public GameObject manualPanel;

    private void Start()
    {
        if (manualPanel != null)
        {
            manualPanel.SetActive(false);
        }
    }

    public void OpenManual()
    {
        if (manualPanel != null)
        {
            manualPanel.SetActive(true);
        }
    }

    public void CloseManual()
    {
        if (manualPanel != null)
        {
            manualPanel.SetActive(false);
        }
    }
}