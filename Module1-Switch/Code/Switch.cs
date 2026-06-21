using UnityEngine;

public class Switch : MonoBehaviour, IElectricalComponent
{
    private Transform lever;
    private bool isOn = false;
    private Circuit circuit;

    public bool IsActive => isOn;

    private void Start()
    {
        lever = transform.Find("SwitchLever");
        circuit = FindObjectOfType<Circuit>();
    }

    public void SetActive(bool active)
    {
        isOn = active;

        if (circuit != null)
        {
            circuit.OnComponentChanged();
        }
    }

    public void Toggle()
    {
        isOn = !isOn;

        if (circuit != null)
        {
            circuit.OnComponentChanged();
        }

        Debug.Log("Switch is " + (isOn ? "ON" : "OFF"));
    }

    public float GetResistance()
    {
        if (isOn)
            return 0f;  // ON = no resistance
        else
            return 1000000f;  // OFF = very high resistance
    }

    private void LateUpdate()
    {
        if (lever != null)
        {
            if (isOn)
                lever.rotation = Quaternion.Euler(0, 0, -45f);
            else
                lever.rotation = Quaternion.Euler(0, 0, 45f);
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleClick();
        }
    }

    private void HandleClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Check if we hit anything
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Hit: " + hit.collider.name);

            // Check if we hit the switch or its children
            if (hit.collider.CompareTag("Switch") || hit.collider.transform.IsChildOf(transform))
            {
                Debug.Log("Clicked the switch!");
                Toggle();
            }
        }
        else
        {
            Debug.Log("Raycast hit nothing");
        }
    }
}

