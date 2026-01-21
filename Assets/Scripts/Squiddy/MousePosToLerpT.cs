using UnityEngine;
using UnityEngine.InputSystem;

public class MousePosToLerpT : MonoBehaviour
{
    public Vector2 mousePos; //The position of the Mouse in screen space

    public MoveBetweenTwoTransforms lerpScript; //A referance to the component with a variable this script will access



    // Update is called once per frame
    void Update()
    {
        //Find where the mouse is, in screen space
        mousePos = Mouse.current.position.ReadValue();

        //Find the percentage of were it is in the screen in X axis
        float percent = mousePos.x / Screen.width;

        //Set the value in the other script
        lerpScript.lerpT = percent;
    }
}
