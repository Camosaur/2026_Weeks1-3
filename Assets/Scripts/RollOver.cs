using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver : MonoBehaviour
{
    public bool timerIsRunning;
    public float timer = 0f;
    public float maxTimer = 1f;
    public AnimationCurve curve;
    public Transform start;
    public Transform end;
    public float speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //Only count when mouse is close to the sprite
        if (Vector2.Distance(transform.position, mousePos) < 2)
        {
            timerIsRunning = true;
        }
        else
        {
            timerIsRunning = false;
            timer = 0f;
        }

        //Count up the timer
        if (timerIsRunning) {
            timer += Time.deltaTime*speed;
        }

        //Flip speed
        if (timer > maxTimer || timer < 0)
        {
            speed *= -1f;
        }

        //Change rotation along the curve
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(timer));
    }

}
