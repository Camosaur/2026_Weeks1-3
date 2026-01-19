using UnityEngine;
using UnityEngine.InputSystem;

public class GetStupidStuff : MonoBehaviour
{
    [Tooltip ("The position of the Mouse Cursor, in World Space.")]
    public Vector2 mousePos; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
    }
}
