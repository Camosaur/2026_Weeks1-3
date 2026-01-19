using UnityEngine;
using UnityEngine.InputSystem;

public class KeyBoardControl : MonoBehaviour
{
    [Tooltip ("The Speed of Movement. In Metres/Frame")]
    public float speed;

    [Tooltip ("This sprite can move West and East")]
    public bool xAxis;

    [Tooltip("This sprite can move North and South")]
    public bool yAxis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);

        //Can this sprite move along the X-AXIS?
        if (xAxis)
        {
            //Move EAST if D or Right Arrow is pressed.
            //Only do this if you are whithin the RIGHT bound of the screen!
            if ((Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) && (pos.x < Screen.width))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }

            //Move WEST if A or Left Arrow is pressed.
            //Only do this if you are whithin the LEFT bound of the screen!
            if ((Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) && (pos.x > 0))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        //Can this sprite move along the Y-AXIS?
        if (yAxis)
        {
            //Move NORTH if W or UP Arrow is pressed.
            //Only do this if you are whithin the TOP bound of the screen!
            if ((Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) && (pos.y < Screen.height))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }

            //Move SOUTH if S or DOWN Arrow is pressed.
            //Only do this if you are whithin the BOTTOM bound of the screen!
            if ((Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) && (pos.y > 0))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }

    }
}
