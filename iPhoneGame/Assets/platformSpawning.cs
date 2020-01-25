using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawning : MonoBehaviour
{
    public Transform cameraTransform;
    public GameObject platform;
    public float spawnOffset=8;
    private float nextPlatformHeight;

    // Start is called before the first frame update
    void Start()
    {
        nextPlatformHeight = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextPlatformHeight <= cameraTransform.position.y + spawnOffset)
        {
            Instantiate(platform, new Vector2 (Random.Range(-2.5f, 2.5f), nextPlatformHeight), Quaternion.identity);
            nextPlatformHeight += Random.Range(2f, 3f);
        }
    }
}
