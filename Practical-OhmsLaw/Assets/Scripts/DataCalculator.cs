using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataCalculator : MonoBehaviour
{
    // Row 1
    [SerializeField] private TMP_InputField v1Input;
    [SerializeField] private TMP_InputField i1Input;
    [SerializeField] private TextMeshProUGUI r1Text;

    // Row 2
    [SerializeField] private TMP_InputField v2Input;
    [SerializeField] private TMP_InputField i2Input;
    [SerializeField] private TextMeshProUGUI r2Text;

    // Row 3
    [SerializeField] private TMP_InputField v3Input;
    [SerializeField] private TMP_InputField i3Input;
    [SerializeField] private TextMeshProUGUI r3Text;

    // Row 4
    [SerializeField] private TMP_InputField v4Input;
    [SerializeField] private TMP_InputField i4Input;
    [SerializeField] private TextMeshProUGUI r4Text;

    // Row 5
    [SerializeField] private TMP_InputField v5Input;
    [SerializeField] private TMP_InputField i5Input;
    [SerializeField] private TextMeshProUGUI r5Text;

    private void Start()
    {
        // Add listeners to all input fields
        v1Input.onEndEdit.AddListener(delegate { CalculateResistance(v1Input, i1Input, r1Text); });
        i1Input.onEndEdit.AddListener(delegate { CalculateResistance(v1Input, i1Input, r1Text); });

        v2Input.onEndEdit.AddListener(delegate { CalculateResistance(v2Input, i2Input, r2Text); });
        i2Input.onEndEdit.AddListener(delegate { CalculateResistance(v2Input, i2Input, r2Text); });

        v3Input.onEndEdit.AddListener(delegate { CalculateResistance(v3Input, i3Input, r3Text); });
        i3Input.onEndEdit.AddListener(delegate { CalculateResistance(v3Input, i3Input, r3Text); });

        v4Input.onEndEdit.AddListener(delegate { CalculateResistance(v4Input, i4Input, r4Text); });
        i4Input.onEndEdit.AddListener(delegate { CalculateResistance(v4Input, i4Input, r4Text); });

        v5Input.onEndEdit.AddListener(delegate { CalculateResistance(v5Input, i5Input, r5Text); });
        i5Input.onEndEdit.AddListener(delegate { CalculateResistance(v5Input, i5Input, r5Text); });
    }

    private void CalculateResistance(TMP_InputField vInput, TMP_InputField iInput, TextMeshProUGUI rText)
    {
        // Get values from input fields
        if (float.TryParse(vInput.text, out float voltage) && float.TryParse(iInput.text, out float current))
        {
            // Calculate R = V / I
            if (current != 0)
            {
                float resistance = voltage / current;
                rText.text = resistance.ToString("F2") + " Ω";
                Debug.Log("Calculated R = " + resistance.ToString("F2"));
            }
            else
            {
                rText.text = "∞ Ω"; // Division by zero
            }
        }
        else
        {
            rText.text = "0.0 Ω";
        }
    }
}