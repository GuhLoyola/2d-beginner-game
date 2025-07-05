using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
     public InputAction MoveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCharacterMovement();
    }

    private void HandleCharacterMovement()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;

        transform.position = position;
    }
}
