using UnityEngine;

public class ManualUI : MonoBehaviour
{
    public GameObject manualPanel;

    void Start()
    {
        manualPanel.SetActive(false);
    }

    public void OpenManual()
    {
        manualPanel.SetActive(true);
    }

    public void CloseManual()
    {
        manualPanel.SetActive(false);
    }
}