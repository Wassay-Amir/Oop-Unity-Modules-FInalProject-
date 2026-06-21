using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float mouseSensitivity = 2f;
    [SerializeField] private float groundDrag = 5f;

    private Rigidbody playerRb;
    private Camera playerCamera;
    private float xRotation = 0f;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerCamera = GetComponent<Camera>();

        // Show cursor
        Cursor.visible = true;
    }

    private void Update()
    {
        // Handle camera rotation with mouse
        HandleMouseLook();

        // Handle movement input
        HandleMovement();
    }

    private void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotate body left/right
        transform.Rotate(Vector3.up * mouseX);

        // Rotate camera up/down (limited)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }

    private void HandleMovement()
    {
        // Get input
        float horizontal = Input.GetAxis("Horizontal"); // A/D
        float vertical = Input.GetAxis("Vertical");     // W/S

        // Calculate movement direction relative to player facing
        Vector3 moveDirection = transform.forward * vertical + transform.right * horizontal;

        // Apply movement
        if (playerRb != null)
        {
            playerRb.linearVelocity = new Vector3(moveDirection.x * moveSpeed, playerRb.linearVelocity.y, moveDirection.z * moveSpeed);
        }
        else
        {
            // Fallback if no Rigidbody
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
    }
}