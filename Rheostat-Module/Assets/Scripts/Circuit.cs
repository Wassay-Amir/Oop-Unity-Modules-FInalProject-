using UnityEngine;
using System.Collections.Generic;

public class Circuit : MonoBehaviour
{
    [SerializeField] private float voltage = 12f;
    private List<IElectricalComponent> components = new List<IElectricalComponent>();

    private void Start()
    {
        Rheostat[] rheostats = FindObjectsOfType<Rheostat>();

        foreach (Rheostat r in rheostats)
        {
            components.Add(r);
        }

        Debug.Log("Circuit started with " + components.Count + " components");
    }

    public void OnComponentChanged()
    {
        float totalResistance = 0f;

        foreach (IElectricalComponent component in components)
        {
            totalResistance += component.GetResistance();
        }

        float current = 0f;
        if (totalResistance > 0)
        {
            current = voltage / totalResistance;
        }

        Debug.Log("Voltage: " + voltage + "V | Resistance: " + totalResistance + "Ω | Current: " + current + "A");
    }
}