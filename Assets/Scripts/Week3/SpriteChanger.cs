using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer costume;
    public Color paint;
    public List<Sprite> masks;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());


        if (costume.bounds.Contains(mousePos))
        {
            if (costume.color == paint) {
                PickARandomColor();

                //Salvation
                if (masks.Count > 6) {
                    masks.Remove(masks[masks.Count - 1]);
                }
            }
            
        }
        else
        {
            costume.color = paint;
        }


        if (Mouse.current.leftButton.wasPressedThisFrame) {
            PickARandomSprite();
        }

    }

    void PickARandomColor() {

        costume.color = Random.ColorHSV();
    
    }

    void PickARandomSprite()
    {
        int index = Random.Range(0, masks.Count);
        costume.sprite = masks[index];

        //Invasion!
        masks.Add(masks[masks.Count-1]);

    }
}
