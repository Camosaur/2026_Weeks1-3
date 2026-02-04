using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class EnemyHealthbar : MonoBehaviour
{
    public SpriteRenderer costume;
    public Slider healthbar;


    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in world coordinates
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        // Check if the mouse is over the enemy's costume and if the left mouse button was pressed
        if (costume.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        {
            healthbar.value += 0.1f;
        }

        // Destroy the enemy when healthbar is full
        if (healthbar.value >= healthbar.maxValue)
        {
            Destroy(gameObject);
        }
    }
}
