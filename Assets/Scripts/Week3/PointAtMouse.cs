using UnityEngine;

public class PointAtMouse : MonoBehaviour
{
    public GetStupidStuff finder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Find the direction to the mouse cursor
        Vector2 direction = finder.mousePos - (Vector2)transform.position;

        //Make the rotation point at that!
        transform.up = direction;

    }
}
