using UnityEngine;
using UnityEngine.InputSystem;

public class XAxisKeyBoardControl : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Move RIGHT if D or Right Arrow is pressed.
        //Only do this if you are whithin the RIGHT bound of the screen!
        if ((Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)&&(Camera.main.WorldToScreenPoint(transform.position).x < Screen.width)) {
                transform.position += Vector3.right * speed * Time.deltaTime;
        }

        //Move LEFT if A or Left Arrow is pressed.
        //Only do this if you are whithin the LEFT bound of the screen!
        if ((Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)&&(Camera.main.WorldToScreenPoint(transform.position).x > 0))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

    }
}
