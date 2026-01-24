using UnityEngine;

public class growWhenCursorNearby : MonoBehaviour
{
    public Timer t; //The timer I'll use for this
    public GetStupidStuff finder; //To find the mouse pointer

    //Curve
    public AnimationCurve curve; // The animationCurve I map

    //For tracking the mouse
    public bool mouseInRadius = false;
    public bool pMouseInRadius = false;
    public float radius;


    void Start()
    {
        //Initialize the timer
        t = GetComponent<Timer>();
        finder = GetComponent<GetStupidStuff>();
    }

    // Update is called once per frame
    void Update()
    {
        //---When the mouse enters or leaves a certain radius, reset the timer once

        //If the mouse is outside the radius...
        if (Vector2.Distance(finder.mousePos, transform.position) > radius) { 
            mouseInRadius = false;
        }
        else { 
            mouseInRadius = true;
        }

        //If the mouse is different from the previous frame...
        if (mouseInRadius != pMouseInRadius) {
            t.Reset();
        }

        //Save the last frame
        pMouseInRadius = mouseInRadius;


        //Set the scale
        transform.localScale = Vector3.one * (t.currentCount);
        
    }
}
