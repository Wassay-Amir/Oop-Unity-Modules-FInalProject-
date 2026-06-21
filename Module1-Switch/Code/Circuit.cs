using UnityEngine;
using System.Collections.Generic;

public class Circuit : MonoBehaviour
{
    [SerializeField] private float voltage = 12f;
    private List<IElectricalComponent> components = new List<IElectricalComponent>();

    private void Start()
    {
        // Find all switches
        Switch[] switches = FindObjectsOfType<Switch>();

        foreach (Switch s in switches)
        {
            components.Add(s);
        }

        Debug.Log("Circuit started with " + components.Count + " components");
    }

    public void OnComponentChanged()
    {
        float totalResistance = 0f;

        // Add up all resistances
        foreach (IElectricalComponent component in components)
        {
            totalResistance += component.GetResistance();
        }

        // Calculate current using Ohm's Law
        float current = 0f;
        if (totalResistance > 0)
        {
            current = voltage / totalResistance;
        }

        Debug.Log("Voltage: " + voltage + "V, Resistance: " + totalResistance + "Ω, Current: " + current + "A");
    }

    public float GetTotalResistance()
    {
        float total = 0f;

        foreach (IElectricalComponent component in components)
        {
            total += component.GetResistance();
        }

        return total;
    }
}