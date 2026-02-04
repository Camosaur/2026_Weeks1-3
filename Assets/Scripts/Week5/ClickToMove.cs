using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ClickToMove : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true && !EventSystem.current.IsPointerOverGameObject()) { 
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = mousePos;
        }
        
    }
}
