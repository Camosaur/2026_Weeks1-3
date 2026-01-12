using UnityEngine;

public class Pulse : MonoBehaviour
{

    public AnimationCurve curve;
    public float t = 0f;
    public float speed = 0.3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;
        if (t > 1 || t < 0)
        {
            speed *= -1;
        }

         Vector3 newSize = Vector3.one * curve.Evaluate(t);
        transform.localScale = newSize;
    }
}
