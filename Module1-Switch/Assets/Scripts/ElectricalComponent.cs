using UnityEngine;

public interface IElectricalComponent
{
    bool IsActive { get; }
    float GetResistance();
    void SetActive(bool active);
}