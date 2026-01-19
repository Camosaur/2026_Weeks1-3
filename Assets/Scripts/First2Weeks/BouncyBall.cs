using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public float speedX;
    public float speedY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //Never finished this one...
    }
}
