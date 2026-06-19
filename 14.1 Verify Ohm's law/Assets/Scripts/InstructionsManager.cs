using UnityEngine;
using UnityEngine.UI;

public class InstructionsManager : MonoBehaviour
{
    [SerializeField] private GameObject instructionsPanel;
    [SerializeField] private Button openButton;
    [SerializeField] private Button closeButton;

    private void Start()
    {
        // Panel is hidden by default
        instructionsPanel.SetActive(false);

        // Button listeners
        if (openButton != null)
            openButton.onClick.AddListener(OpenInstructions);

        if (closeButton != null)
            closeButton.onClick.AddListener(CloseInstructions);
    }

    public void OpenInstructions()
    {
        instructionsPanel.SetActive(true);
        Debug.Log("Instructions opened");
    }

    public void CloseInstructions()
    {
        instructionsPanel.SetActive(false);
        Debug.Log("Instructions closed");
    }
}