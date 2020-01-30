using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeMove : MonoBehaviour
{
    private bool goingRight; //if not then going left
    private float speed;
    private float color = 0;
    private bool colorAscending = true;
    // Start is called before the first frame update

    void Start()
    {
        goingRight = (Random.value > 0.5f);
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (colorAscending && color >= 1)
        {
            colorAscending = false;
        }
        else if (!colorAscending && color <= 0)
        {
            colorAscending = true;
        }

        if (colorAscending)
            color += .01f;
        else
            color -= .01f;


        Color curColor = Color.HSVToRGB(color, .5f, 1f);

        GetComponent<SpriteRenderer>().color = curColor;
    }

    void FixedUpdate() {
        if (transform.position.x >= 2.9 || transform.position.x <= -2.9)
        {
            goingRight = !goingRight;
        }

        if (goingRight)
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        else
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
