using UnityEngine;

public class GrabSystem : MonoBehaviour
{
    private GameObject heldObject = null;
    private float grabDistance = 2f;
    private float holdDistance = 1.5f;

    [SerializeField] private Color highlightColor = Color.yellow;
    private Color originalColor;
    private Material originalMaterial;

    private void Update()
    {
        HandleHover();
        HandleGrab();
    }

    private void HandleHover()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, grabDistance))
        {
            if (hit.collider.CompareTag("Instrument"))
            {
                // Highlight the instrument on hover
                Renderer renderer = hit.collider.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.material.color = highlightColor;
                }
            }
        }
    }

    private void HandleGrab()
    {
        // Click to grab
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, grabDistance))
            {
                if (hit.collider.CompareTag("Instrument"))
                {
                    heldObject = hit.collider.gameObject;

                    // Store original color
                    Renderer renderer = heldObject.GetComponent<Renderer>();
                    if (renderer != null)
                    {
                        originalColor = renderer.material.color;
                        originalMaterial = renderer.material;
                    }

                    // Make it draggable
                    Rigidbody rb = heldObject.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.isKinematic = true;
                    }

                    Debug.Log("Grabbed: " + heldObject.name);
                }
            }
        }

        // Drag held object
        if (Input.GetMouseButton(0) && heldObject != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 newPosition = ray.origin + ray.direction * holdDistance;
            heldObject.transform.position = newPosition;
        }

        // Release
        if (Input.GetMouseButtonUp(0) && heldObject != null)
        {
            // Restore original color
            Renderer renderer = heldObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = originalColor;
            }

            // Make it solid again
            Rigidbody rb = heldObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
            }

            Debug.Log("Released: " + heldObject.name);
            heldObject = null;
        }
    }
}