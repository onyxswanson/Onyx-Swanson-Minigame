using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 20.0f;
    public GameObject projectilePrefab;
    public InputAction fireAction;
    public Quaternion bulletRotation = Quaternion.Euler(0f, 0f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * moveInput.y * Time.deltaTime * speed);
        if (fireAction.triggered)
        {
            if (Keyboard.current.leftArrowKey.isPressed)
            {
                bulletRotation = Quaternion.Euler(0f, 270f, 0f);
            }
            if (Keyboard.current.rightArrowKey.isPressed)
            {
                bulletRotation = Quaternion.Euler(0f, 90f, 0f);
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                bulletRotation = Quaternion.Euler(0f, 180f, 0f);
            }
            if (Keyboard.current.upArrowKey.isPressed)
            {
                bulletRotation = Quaternion.Euler(0f, 0f, 0f);
            }

            Instantiate(projectilePrefab, transform.position, bulletRotation);
        }
    }
}
