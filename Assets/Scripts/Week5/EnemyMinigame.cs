using UnityEngine;
using System.Collections.Generic;

public class EnemyMinigame : MonoBehaviour
{

    public List<GameObject> duckies;
    public GameObject duckiePrefab;
    public GameObject victoryText;
    public Timer timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Set the victory text to be inactive at the start
        victoryText.SetActive(false);

        for (int i = 0; i < 5; i++) {
            //Vector2 newPos = new Vector2(Random.Range(0, Camera.main.ScreenToWorldPoint(Screen.width)), Random.Range(0, Camera.main.ScreenToWorldPoint(Screen.height)));
            transform.position = Random.insideUnitCircle * Random.Range(0, 5);
            duckies.Add(Instantiate(duckiePrefab, transform.position, transform.rotation));
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        //Purge null duckies from the list
        for (int i = duckies.Count - 1; i >= 0; i--) {
            if (duckies[i] == null) {
                duckies.RemoveAt(i);
            }
        }

        //Every second, spawn a new duckie
        if (timer.isDone()) {
            transform.position = Random.insideUnitCircle * Random.Range(0, 5);
            duckies.Add(Instantiate(duckiePrefab, transform.position, transform.rotation));
        }

        //Check for victory. If so, show victory text
        if (duckies.Count == 0) {
            victoryText.SetActive(true);
        }
    }
}
