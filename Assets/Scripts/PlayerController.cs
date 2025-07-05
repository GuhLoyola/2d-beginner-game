using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    public float speed = 3.0f;

    public int maxHealth = 5;
    int currentHealth = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();

        //currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HandleCharacterMovement();
    }

    void FixedUpdate()
    {
        Vector2 position = (Vector2)transform.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    private void HandleCharacterMovement()
    {
        move = MoveAction.ReadValue<Vector2>();
    }

    public void changeHealth(int amount) 
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
    }
}
