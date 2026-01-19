using UnityEngine;

public class MoveBetweenTwoTransforms : MonoBehaviour
{
    //This script moves an object between two points!

    //The points I start and end on
    public Transform start;
    public Transform end;

    public float lerpT; //The T value (between 0.0 and 1.0) that I use to lerp between two points
    public float speed; //The speed at wich the object lerps, per second

    public AnimationCurve positionToLerpT; // The animationCurve I map onto T

    public bool changeX; //Weather this script will effect X axis
    public bool changeY; //Weather this script will effect Y axis


    // Update is called once per frame
    void Update()
    {
        //Update the T value 
        lerpT += Time.deltaTime * speed;


        //If the end of the animation is reached, reverse the speed
        if (lerpT > 1 || lerpT < 0)
        {
            speed *= -1;
        }


        //The position this object was lerped to
        Vector2 newPosition = Vector2.Lerp(start.position, end.position, positionToLerpT.Evaluate(lerpT));

        //If we aren't changing the x axis, set newPosition's x back to how it was
        if (!changeX) {
            newPosition.x = transform.position.x;
        }

        //If we aren't changing the y axis, set newPosition's y back to how it was
        if (!changeY)
        {
            newPosition.y = transform.position.y;
        }

        //Set transform to the new position
        transform.position = newPosition;
    }
}
