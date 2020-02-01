using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeMove : MonoBehaviour
{
    private bool goingRight; //if not then going left
    private float speed;
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
        float color = playerScore.color + .25f;
        if (color > 1f)
        {
            color -= 1;
        }


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
