﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (transform.position.y < playerTransform.position.y)
            transform.position = new Vector2(transform.position.x, playerTransform.position.y);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y+speed*Time.deltaTime);
    }
}
