using UnityEngine;
using UnityEngine.UI;

public class TimerVisualize_UI : MonoBehaviour
{

    public Timer clock;
    public Slider UIVisual;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIVisual.value = clock.currentCount;
    }
}
