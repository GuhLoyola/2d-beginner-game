using UnityEngine;

public class HealthCollectibe : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.changeHealth(1);
            Destroy(gameObject);
        }
    }
}
