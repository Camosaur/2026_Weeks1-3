using UnityEngine;

public class ToggleBoolButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleBool()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
