using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer costume;
    public Color paint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());


        if (costume.bounds.Contains(mousePos))
        {
            costume.color = paint;
        }
        else { costume.color = Color.white; }

    }

    void PickARandomColor() {

        costume.color = Random.ColorHSV();
    
    }
}
