using UnityEngine;
using TMPro;

public class Voltmeter : MonoBehaviour
{
    [Header("Meter Terminals")]
    public Terminal Positive;

    public Terminal Negative;

    [Header("Display")]
    public TMP_Text Display;

    [Header("Settings")]
    public bool ShowAbsoluteValue = false;

    void Update()
    {
        if (Positive == null ||
            Negative == null ||
            Display == null)
        {
            return;
        }

        float voltage =
            Positive.Voltage -
            Negative.Voltage;

        if (ShowAbsoluteValue)
        {
            voltage = Mathf.Abs(voltage);
        }

        Display.text =
            voltage.ToString("F2") + " V";
    }

    public float GetVoltage()
    {
        if (Positive == null || Negative == null)
            return 0f;

        return Positive.Voltage - Negative.Voltage;
    }
}