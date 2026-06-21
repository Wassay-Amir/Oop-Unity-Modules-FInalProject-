using UnityEngine;

public class Terminal : MonoBehaviour
{
    [Header("Voltage at this node")]
    public float Voltage = 0f;

    [Header("Connection Status")]
    public bool IsConnected = false;
}