using UnityEngine;
using UnityEngine.UI;

public class DataTableManager : MonoBehaviour
{
    [SerializeField] private GameObject dataTablePanel;
    [SerializeField] private Button dataTableButton;

    private bool isTableVisible = false;

    private void Start()
    {
        // Panel starts hidden
        dataTablePanel.SetActive(false);

        // Button listener
        if (dataTableButton != null)
            dataTableButton.onClick.AddListener(ToggleDataTable);
    }

    public void ToggleDataTable()
    {
        isTableVisible = !isTableVisible;
        dataTablePanel.SetActive(isTableVisible);

        if (isTableVisible)
            Debug.Log("Data Table opened");
        else
            Debug.Log("Data Table closed");
    }
}