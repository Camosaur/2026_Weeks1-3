using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t = 0f;
    public float speed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime*speed;
        if (t > 1 || t < 0)
        { 
            speed *= -1; 
        }


        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
