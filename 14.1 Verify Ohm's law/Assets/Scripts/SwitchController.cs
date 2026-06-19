using System;
using UnityEngine;

/// <summary>
/// Controls a clickable switch object in the scene.
/// When clicked, toggles the circuit between open (off) and closed (on).
/// Fires OnSwitchChanged whenever state changes, so CircuitManager can react.
/// </summary>
public class SwitchController : MonoBehaviour
{
    [Header("State")]
    [Tooltip("True = circuit closed (current can flow). False = circuit open.")]
    public bool isClosed = false;

    [Header("Visuals (optional)")]
    [Tooltip("Optional: rotate/move this transform to show switch position. Leave empty if not used yet.")]
    public Transform switchVisual;
    [Tooltip("Local rotation Z when switch is OFF (open).")]
    public float openRotationZ = 0f;
    [Tooltip("Local rotation Z when switch is ON (closed).")]
    public float closedRotationZ = 30f;

    // Other scripts (like CircuitManager) subscribe to this event.
    public static event Action<bool> OnSwitchChanged;

    void Start()
    {
        ApplyVisualState();
    }

    /// <summary>
    /// Call this from an EventTrigger / OnMouseDown / Button OnClick, etc.
    /// </summary>
    public void ToggleSwitch()
    {
        isClosed = !isClosed;
        ApplyVisualState();

        Debug.Log("Switch is now " + (isClosed ? "CLOSED (circuit on)" : "OPEN (circuit off)"));

        OnSwitchChanged?.Invoke(isClosed);
    }

    // If the switch is a 3D/2D object with a Collider, this lets you click it directly in the world.
    void OnMouseDown()
    {
        ToggleSwitch();
    }

    private void ApplyVisualState()
    {
        if (switchVisual == null) return;

        Vector3 currentEuler = switchVisual.localEulerAngles;
        currentEuler.z = isClosed ? closedRotationZ : openRotationZ;
        switchVisual.localEulerAngles = currentEuler;
    }
}