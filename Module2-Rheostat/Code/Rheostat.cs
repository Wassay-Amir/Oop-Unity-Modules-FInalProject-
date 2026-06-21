using UnityEngine;

public class Rheostat : MonoBehaviour, IElectricalComponent
{
    private Transform slider;
    private Circuit circuit;

    [SerializeField] private float maxResistance = 100f;
    [SerializeField] private float minY = -1.5f;
    [SerializeField] private float maxY = 1.5f;

    private bool isDragging = false;
    private float currentResistance = 50f;

    public bool IsActive => true;

    private void Start()
    {
        slider = transform.Find("Slider");
        circuit = FindObjectOfType<Circuit>();
        Debug.Log("Rheostat initialized");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.transform.IsChildOf(transform))
                {
                    isDragging = true;
                }
            }
        }

        if (Input.GetMouseButton(0) && isDragging)
        {
            DragSlider();
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }
    }

    private void DragSlider()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane dragPlane = new Plane(Vector3.forward, slider.position);

        float distance = 0f;
        if (dragPlane.Raycast(ray, out distance))
        {
            Vector3 hitPoint = ray.origin + ray.direction * distance;
            float newY = hitPoint.y;
            newY = Mathf.Clamp(newY, minY, maxY);

            slider.position = new Vector3(slider.position.x, newY, slider.position.z);
            UpdateResistance();
        }
    }

    private void UpdateResistance()
    {
        float percentage = (slider.position.y - minY) / (maxY - minY);
        percentage = Mathf.Clamp01(percentage);

        currentResistance = percentage * maxResistance;

        if (circuit != null)
        {
            circuit.OnComponentChanged();
        }
    }

    public float GetResistance()
    {
        return currentResistance;
    }

    public void SetActive(bool active)
    {
    }
}