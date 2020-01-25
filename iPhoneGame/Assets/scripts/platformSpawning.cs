using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawning : MonoBehaviour
{
    public Transform cameraTransform;
    public GameObject platform;
    public GameObject deathCircle;
    public float spawnOffset=8;
    private float nextPlatformHeight;
    private float nextDeathHeight;


    // Start is called before the first frame update
    void Start()
    {
        nextPlatformHeight = -1;
        nextDeathHeight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextPlatformHeight <= cameraTransform.position.y + spawnOffset)
        {
            //spawn 2 
            Instantiate(platform, new Vector2 (Random.Range(-2.5f, 2.5f), nextPlatformHeight), Quaternion.identity);
            Instantiate(platform, new Vector2 (Random.Range(-2.5f, 2.5f), nextPlatformHeight), Quaternion.identity);
            nextPlatformHeight += Random.Range(2f, 3f);
        }

        if (nextDeathHeight <= cameraTransform.position.y + spawnOffset)
        {
            Instantiate(deathCircle, new Vector3 (Random.Range(-2.5f, 2.5f), nextDeathHeight, -2f), Quaternion.identity);
            nextDeathHeight += Random.Range(1f, 4f);
        }
    }
}
