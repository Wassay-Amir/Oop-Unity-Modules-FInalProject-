using UnityEngine;
using TMPro;

public class DisplayUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resistanceText;
    [SerializeField] private TextMeshProUGUI currentText;

    private Rheostat rheostat;

    private void Start()
    {
        rheostat = FindObjectOfType<Rheostat>();

        if (rheostat == null)
        {
            Debug.Log("Rheostat not found!");
        }
    }

    private void Update()
    {
        if (rheostat != null)
        {
            float resistance = rheostat.GetResistance();
            float voltage = 12f;
            float current = 0f;

            if (resistance > 0)
            {
                current = voltage / resistance;
            }

            resistanceText.text = "Resistance: " + resistance.ToString("F1") + "Ω";
            currentText.text = "Current: " + current.ToString("F4") + "A";

            Debug.Log("R=" + resistance + " I=" + current);
        }
    }
}