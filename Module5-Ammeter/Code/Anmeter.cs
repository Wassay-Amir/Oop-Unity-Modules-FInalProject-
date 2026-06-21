using UnityEngine;
using TMPro;

public class Ammeter : MonoBehaviour
{
    public Terminal Positive;
    public Terminal Negative;
    public TMP_Text Display;

    void Update()
    {
        if (Positive == null || Display == null)
            return;

        float current = Positive.Current;

        Display.text = current.ToString("F2") + " A";
    }

    public float GetCurrent()
    {
        if (Positive == null)
            return 0f;

        return Positive.Current;
    }
}