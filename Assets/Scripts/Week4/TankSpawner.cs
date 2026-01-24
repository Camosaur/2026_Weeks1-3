using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;

    public KeyBoardControl tankScript;
    public GameObject spawnedTank;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            spawnedTank = Instantiate(tankPrefab, transform.position, transform.rotation);
            howManyTanks++;
            tankScript = spawnedTank.GetComponent<KeyBoardControl>();
            tankScript.speed = howManyTanks;

        }
    }
}
